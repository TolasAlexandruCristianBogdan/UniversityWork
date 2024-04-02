%%
close all
clear all
clc

Kf = 3;
Tf = 4;

Hf = tf(Kf,conv([1 0],[Tf 1]))
bode(Hf)
tr = 1;
sigma = 0.02;

zeta = abs(log(sigma))/sqrt(log(sigma)^2 + pi^2);
wn = 4 / (tr * zeta);
cv = wn / (2 * zeta)
delta_w_b = wn * sqrt(1 - 2 * zeta^2 + sqrt(2 - 4 * zeta^2 + 4 * zeta^4))

A = 1 / (4 * sqrt(2) * zeta^2);
Adb = mag2db(A);
wf = 1 / Tf;

F = 18.5;
Vr_dB = Adb - F;
Vr = db2mag(Vr_dB);

Hd = Vr * Hf;
figure;
step(Hd / (1 + Hd )); title("P")

ts = 25;

figure;
bodemag(Hd)

cvol = db2mag(-20.1)
%%
td = Tf;

ts_star = 5;

Tn = td * (ts_star / ts);

kpd = 1 / (ts_star / ts);

Hpd = kpd * tf([td 1],[Tn 1]);

Hdpd = Hd * Hpd;

figure;
step(Hdpd / (1 + Hdpd)); title("PD")

figure;
bode(Hdpd)

cvol2 = db2mag(-5)
%%
wt = 0.53;

wz = 0.1 * wt;
wp = wz * cvol2 / 3;

kpi = 3 / cvol2;

Tz = 1 / wz;
Tp = 1 / wp;

Hpi = kpi * tf([Tz 1],[Tp 1]);

Hdpid = Hdpd * Hpi;

figure;
step(Hdpid / (1 + Hdpid)); title("PID");

figure;
bodemag(Hdpid)

cvol3 = db2mag(9.6)