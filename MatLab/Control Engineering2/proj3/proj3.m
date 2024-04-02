% Magnitude
close all
clear all
clc

Kf = 3;
Tf = 4;

Hf = tf(Kf,conv([1 0],[Tf 1]))

T_sigma = Tf;
wn = 1 / (sqrt(2)*T_sigma);
zeta = 1 / sqrt(2);
ts = 8 * T_sigma;
sigma = exp(-pi) * 100;
cv = 1 / (2 * T_sigma);
Essv = 2 * T_sigma;

Hd = tf(1,conv([2*T_sigma 0],[T_sigma 1]));

Hc = Hd / Hf;

Hcl = minreal(feedback(Hc * Hf, 1))
figure; step(Hcl); title('Closed loop - magnitude');

t = 0:0.1:100;
figure; lsim(Hcl, t, t); title('Closed loop - mag');

%Symmetrical
%
ts_s = 16 * T_sigma;

Hd = tf([4*T_sigma 1],conv([8*T_sigma^2 0 0],[T_sigma 1]));
Hc = Hd / Hf;

Hcl2 = minreal(feedback(Hc * Hf, 1))
figure; step(Hcl2); title('Closed loop - symmetrical');

figure; lsim(Hcl2, t, t); title('Closed loop - sym');