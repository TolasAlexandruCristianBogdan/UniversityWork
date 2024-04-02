%% Controller Design part 2
%se schimba overshootu 
%step si lsim ca sa verificam performantele
%daca nu merge facem controlleru PD  td>Tn ii regulator PD 
% daca e invers e PI
%unde modulul intersecteaza 0 acolo e wt (omega de taiere)
%ts* cat vreau sa am
%tau d e constanta de timp de la Tf)

%% a
% Estp = 0;
% sigma < 10%
% ts <= 3 sec;
% cv >= 2;
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
sigma = 0.1;
zeta = abs(log(sigma))/(sqrt((log(sigma))^2 + pi^2))
ModulA = 1/(4*sqrt(2)*(zeta^2))

A = mag2db(ModulA)
Vr= hwf - A
VR=db2mag(-Vr)
Hrp=VR
Hd=Hrp*Hf;
bode(Hd)
wt1=1.23;

wn=2*zeta*wt1
tsi=1
ts = 2/zeta^2/wt1;

cv=wn/(2*zeta)
wt2=wt1*(ts/tsi)

tau_d=Tf

Tn=tau_d*(tsi/ts)

Vrpd=wt2/wt1
Hrpd=Vrpd * tf([tau_d 1],[Tn 1])
Hpd = VR * Hf * Hrpd

H0=Hpd/(Hpd+1)
step(H0)
figure;hold on
t=0:0.1:20;
lsim(H0,t,t)

%% b 
% Estp = 0;
% sigma < 10%
% ts <= 1 sec;
% cv >= 2;
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
sigma = 0.1;
zeta = abs(log(sigma))/(sqrt((log(sigma))^2 + pi^2))
ModulA = 1/(4*sqrt(2)*(zeta^2))

A = mag2db(ModulA)
Vr= hwf - A
VR=db2mag(-Vr)
Hrp=VR
Hd=Hrp*Hf;
bode(Hd)
wt1=1.23;

wn=2*zeta*wt1
tsi=1
ts = 2/zeta^2/wt1;

cv=wn/(2*zeta)
wt2=wt1*(ts/tsi)
cv=wn/(2*zeta)
wz=0.1*wt2
cvi=2
wp=(wz*cv)/cvi

Tn=tau_d*(tsi/ts)

Vrpd=wt2/wt1
Hrpd=Vrpd * tf([tau_d 1],[Tn 1])
Hpd = VR * Hf * Hrpd

H0=Hpd/(Hpd+1)
step(H0)
figure;hold on
t=0:0.1:20;
lsim(H0,t,t)
