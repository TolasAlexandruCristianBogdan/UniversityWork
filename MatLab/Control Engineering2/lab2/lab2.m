%%
%Transfer Function
num=2;
den=conv([1 1],[10 1]);
Hp=tf(num,den,'IOdelay',1)
bode(Hp)
Hp_d=c2d(Hp,0.1,'zoh')
%%
%Control PI

%Cutting freq  (it is read from the bode phase plot at -105 degrees)
wc=0.297;

%Time const
Ti=4/wc;

%Magnitude of Hp(wc)  (it is read from the bode mag plot at wc)
mag = -4.27;

%Formula for kp 
kpi=1/(db2mag(mag));

%PI Controller
Hpi = kpi * (1 + tf([1],[Ti 0]))

H=Hpi*Hp;
bode(H)
Hc_d=c2d(Hpi,0.1,'zoh')
%% 
%PD controller
beta=0.1;

%We find the phase from where we will read the wc
x=atand((1-beta)/(2*sqrt(beta)))
pwc=-120-x    %-174degree
wc2=0.881;

%TimeConst
Td=1/(sqrt(beta)*wc2);

%Magnitude of Hp(wc)  (it is read from the bode mag plot at wc)
mag2 = -15.4;

%Formula for kd
kd=sqrt(beta)/(db2mag(mag2));

%PD Controller
Hpd= kd * (tf([Td 1],[Td*beta 1]));

H=Hpd*Hp;
bode(H)
Hd_d=c2d(Hpd,0.1,'zoh')