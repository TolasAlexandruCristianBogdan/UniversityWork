%% a
% Estp = 0;
% sigma < 15%
% tr <= 15 sec;
% cv >= 1;
% delta_omega_b <= 15 rad/sec;
clc
clear all
close all

Kf = 3.5;
Tf = 0.5;
Hf =tf(Kf,conv([1 0],[Tf 1]))
bode(Hf)

wf = 1/Tf;
hwf = 1.81; % val e in dB
sigma = 0.15;
zeta = abs(log(sigma))/(sqrt((log(sigma))^2 + pi^2))
ModulA = 1/(4*sqrt(2)*(zeta^2))

A = mag2db(ModulA)
Vr= hwf - A
VR=db2mag(-Vr)

Hd=VR*Hf;
bode(Hd)

wt=1.5;
wn=2*zeta*wt
ts=4/(zeta*wn)
cv=wn/(2*zeta)

H0=Hd/(Hd+1)
step(H0)

%% b
% Estp = 0
% sigma <= 15%
% ts < 15 sec
% cv >= 5
% delta_omega_b <= 15 rad/sec

clc
close all
clear all

Kf = 3.5;
Tf = 0.5;
Hf =tf(Kf,conv([1 0],[Tf 1]))
bode(Hf)

hwf = 1.81;
wf = 1/Tf
sigma = 0.15;
zeta = abs(log(sigma))/(sqrt((log(sigma))^2 + pi^2))
ModulA = 1/(4*sqrt(2)*(zeta^2))
A = mag2db(ModulA) % A in db

Vr = hwf - A;
VR = db2mag(-Vr)


Hd = VR * Hf;
bode(Hd); 
wt = 1.5;

wn = 2 * zeta * wt
ts = 4 / (zeta*wn)
cv = wn / (2*zeta)

wz = 0.1 * wt;
wp = (cv / 10) * wz;

Tz = 1/wz;
Tp = 1/wp;

Vrpi = 10/cv;

Hpi = tf([Tz 1],[Tp 1]) * VR * Vrpi;

Hdc = Hf * Hpi;
Ho = Hdc/(1 + Hdc);
step(Ho)

