%% Kalma's Method

%Transfer Function
Hf=tf(1,[3.34 1],'IODelay',1.86);

%Sampling period
Ts=0.5;
 
%Discretization
Hf_Dis=c2d(Hf,Ts,'zoh');

%A and B 
B=[zeros(1,Hf_Dis.IODelay) Hf_Dis.Numerator{:}]
A=[Hf_Dis.Denominator{:} zeros(1,Hf_Dis.IODelay)]

%The gain of the tf
k=1/sum(B);

%Polinoms B and Q
P=k * B;
Q=k * A;

%Controller
Hc=tf(Q,[1 zeros(1,length(B)-1)]-P,Ts);

%Close Loop TF
Hcl=(Hc*Hf_Dis)/(1+Hc*Hf_Dis);
step(Hcl)

%% Dahlin Method

%Transfer function 
Hf=tf(0.2,conv([50 1],[3 1]),'IODelay',2)

%Sampling period
Ts=1;

%Discretization
Hf_dis=c2d(Hf,Ts,'zoh');

%Delay time and lamda
tm=-2;
lamda=40;     %it should be < 50+3

%N
N=tm/Ts;

%A AND B
A=Hf_dis.Denominator{:};
B=Hf_dis.Numerator{:};
b1=B(2);
b2=B(3);
a1=A(2);
a2=A(3);
z=tf('z');

%Hc with ringing
Hc_zr=(((1+a1*z^(-1)+a2*z^(-2))*(1-exp(-Ts/lamda))))/((b1+b2*z^(-1))*(1-exp(-Ts/lamda)*z^(-1)-(1-exp(-Ts/lamda)*z^(-N-1))))
%Hc without ringing
Hc_z=(((1+a1*z^(-1)+a2*z^(-2))*(1-exp(-Ts/lamda))))/((b1+b2)*(1-exp(-Ts/lamda)*z^(-1)-(1-exp(-Ts/lamda)*z^(-N-1))))

step(feedback(Hc_zr*Hf_dis,1));figure
step(feedback(Hc_z*Hf_dis,1))