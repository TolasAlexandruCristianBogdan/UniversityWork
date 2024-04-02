clear all;
sigma = 10/100;
Dsigma=1.08-1
sigma2=sigma-Dsigma
zeta=abs(log(sigma2)/sqrt(log(sigma2)^2+pi^2))
ts=6;
wn=4/(ts*zeta)
wb= wn * sqrt(1-(2*zeta^2) +sqrt(2-(4*zeta^2)+(4*zeta^4)))
cv2=wn/(2*zeta)
cv=1.5;
cvc=cv-cv2
pc=Dsigma/((1/cv2)-1/cv)
zc=pc/(Dsigma+1)
H=(tf(wn^2,[1 2*zeta*wn wn^2]))*(tf(pc*[1 zc],zc*[1 pc]));
subplot(211);step(H);
t=0:0.1:50;
subplot(212);lsim(H,t,t);
essp=50-47.3