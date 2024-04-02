%% a)
sigma=15/100
zeta=abs(log(sigma)/sqrt(log(sigma)^2+pi^2))
ts=30
wn=4/(ts*zeta)
cv=wn/(2*zeta)
wb= wn * sqrt(1-(2*zeta^2) +sqrt(2-(4*zeta^2)+(4*zeta^4)))
H=tf(wn^2,[1 2*zeta*wn wn^2]);
step(H);

%% b)
sigma = 15/100
zeta=abs(log(sigma)/sqrt(log(sigma)^2+pi^2))
ts=6
wn=4/(ts*zeta)
cv=wn/(2*zeta)
wb= wn * sqrt(1-(2*zeta^2) +sqrt(2-(4*zeta^2)+(4*zeta^4)))
H=tf(wn^2,[1 2*zeta*wn wn^2]);
step(H);