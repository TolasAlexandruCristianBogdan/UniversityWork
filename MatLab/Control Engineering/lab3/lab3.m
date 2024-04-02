%%
%3.a
Hf=tf(1,[2 1])
Hr=tf(2)
H0=Hf*Hr/(1+Hf*Hr)
step(H0);grid
essp=1-0.66;
cp=(1/essp)-1
bode(Hr*Hf);grid
db2mag(5.2)
%%
%3.b
Hf=tf(1,[2 1])
Hr=tf(2,[1 0])
H0=Hf*Hr/(1+Hf*Hr)
t=0:0.01:50
lsim(H0,t,t)  %intrarea pt rampa e f(t) si in cazul acesta e t
essv=0.5;
cv=1/essv;
bode(Hr*Hf);grid
db2mag(6.02)
%%
%3.c
Hf=tf(1,[2 1])
Hr=tf(2,[1 0 0])
H0=Hf*Hr/(1+Hf*Hr)
t=0:0.01:50
lsim(H0,t.^2,t) 