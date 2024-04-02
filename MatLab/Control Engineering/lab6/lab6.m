%% 1 modul

clear all
close all
clc

s = tf('s');

H = 2/(s + 1);
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc

%% 1 simetrie

clear all;close all;clc

s = tf('s');

H = 2/(s + 1);
Ts = 1;
Hd = (4*Ts*s + 1)/(8*Ts^2*s^2*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 2 modul

clear all
close all
clc

s = tf('s');

H = 2/(s*(s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H)

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 2 simetrie

clear all
close all
clc

s = tf('s');

H = 2/(s*(s + 1));
Ts = 1;
Hd = (4*Ts*s + 1)/(8*Ts^2*s^2*(Ts*s + 1));

Hc = minreal(Hd/H)

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 3 modul

clear all
close all
clc

s = tf('s');

H = 2/((s + 1)*(10*s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 3 simetrie

clear all
close all
clc

s = tf('s');

H = 2/((s + 1)*(10*s + 1));
Ts = 1;
Hd = (4*Ts*s + 1)/(8*Ts^2*s^2*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 4 modul

clear all
close all
clc

s = tf('s');

H = 2/(s*(s + 1)*(10*s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 4 simetrie

clear all
close all
clc

s = tf('s');

H = 2/(s*(s + 1)*(10*s + 1));
Ts = 1;
Hd = (4*Ts*s + 1)/(8*Ts^2*s^2*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 5 modul

clear all
close all
clc

s = tf('s');

H = 2/((s + 1)*(10*s + 1)*(20*s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 5 simetrie

clear all
close all
clc

s = tf('s');

H = 2/((s + 1)*(10*s + 1)*(20*s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 6 modul

clear all
close all
clc

s = tf('s');

H = 2/(s*(s + 1)*(10*s + 1)*(20*s + 1));
Ts = 1;
Hd = 1/(2*Ts*s*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 2*Ts;
cv = 1/Estv;
wn = 1/(sqrt(2)*Ts);
xi = 1/sqrt(2);
ts = 8*Ts;

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc
%% 6 simetrie

clear all;close all;clc

s = tf('s');

H = 2/(s*(s + 1)*(10*s + 1)*(20*s + 1));
Ts = 1;
Hd = (4*Ts*s + 1)/(8*Ts^2*s^2*(Ts*s + 1));

Hc = minreal(Hd/H);

Estp = 0;
Estv = 0;
ts = 13*Ts;
sigma = 43; % procente
PM = 23; % grade

Hd = series(H, Hc);
H0 = feedback(Hd, 1);

t = 1:0.01:20;
subplot(121); step(H0);
subplot(122); lsim(H0, t, t);
Hc