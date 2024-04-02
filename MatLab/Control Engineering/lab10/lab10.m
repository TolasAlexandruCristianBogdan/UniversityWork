%% PI
clear all
H = tf(2,conv([10 1],[5 1]),'IODelay',3);

bode(H);grid;

gamma_k = 50;
beta = 0.1;
wc = 0.143;

Ti = 4/wc;
%%
module_mag = db2mag(-0.60);

kp = 1/abs(module_mag);

s = tf('s');
Hc = kp*(1+1/(Ti*s));

Hol = Hc*H;

figure
bode(Hol);grid;

figure
step(feedback(Hol,1));

%% PD

Hf = tf(2,conv([10 1],[5 1]),'IODelay',3);

bode(Hf);grid;

gamma_k = 50;
beta = 0.1;

%%

phase = -180 - atand((1-beta)/(2*sqrt(beta))) + gamma_k;

wc = 0.306;

kp = sqrt(beta)/db2mag(-9.38);

tau_d = 1/(wc*sqrt(beta));

Hpd = kp * ((1 + tau_d * tf('s'))/(1 + beta * tau_d * tf('s')));

Hol = Hpd * Hf;

Ho = feedback(Hol,1);

figure;
bode(Hol);

figure;
step(Ho);



%% PI

H = tf(2,conv([10 1],[5 1]),'IODelay',3);

bode(H);grid;

gamma_k = 50;
beta = 0.1;
wc = 0.143;

Ti = 4/wc;
%%
module_mag = db2mag(-0.55);

kp = 1/abs(module_mag);

s = tf('s');
Hc = kp*(1+1/(Ti*s));

Hol = Hc*H;

figure
bode(Hol);grid;

figure
step(feedback(Hol,1));

%% PD

Hf = tf(2,conv([10 1],[5 1]),'IODelay',3);

bode(Hf);grid;

gamma_k = 50;
beta = 0.1;

%%

phase = -180 - atand((1-beta)/(2*sqrt(beta))) + gamma_k;

wc = 0.314;

kp = sqrt(beta)/db2mag(-9.75);

tau_d = 1/(wc*sqrt(beta));

Hpd = kp * ((1 + tau_d * tf('s'))/(1 + beta * tau_d * tf('s')));

Hol = Hpd * Hf;

Ho = feedback(Hol,1);

figure;
bode(Hol);

figure;
step(Ho);