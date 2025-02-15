% Introduction to Bode diagrams
%% FOE
k = 1;
T = 5;
H = tf(k, [T, 1]);
bode(H);
grid;
shg;

%% 
wu = 2;
Tu = 2*pi/wu;
t = 0:Tu/50:12*Tu;
lsim(H,sin(t.*wu),t);
hold;
yline(10^(-1),'r');
hold;
yline(-10^(-1),'r');

%% manipulating bode diagram 
w = logspace(-3,2,1000);
bode(H,w);
grid;
shg;

%% getting data from the bode function
[m,ph] = bode(H,w); 
mv  = squeeze(m);
phv = squeeze(ph);

%ploting the bode diagram using mv and phv vectors:

%magnitude:
figure;
subplot(2,1,1);
semilogx(w,20*log10(mv));
% drawing an approximation
hold on;
semilogx([1e-3 1/5 2 20 100],[0 0 -20 -40 -54],'r*-',LineWidth=2);
hold off;

title("Magnitude characteristic");
xlabel('Frequencies \omega (lg)[rad/sec]');
ylabel('|H(j\omega)|^{dB}', 'FontSize', 14);
grid;

%phase:
subplot(2,1,2);
semilogx(w,phv,'b-');
hold on;
semilogx([1e-3 0.02 0.2 2 100],[0 0 -45 -90 -90],'r*-',LineWidth=2);
hold off
title("Phase characteristic");
xlabel('Frequencies \omega (lg)[rad/sec]');
ylabel('\angle H(j\omega) [deg]', 'FontSize', 14);
grid;

%% Modifying the script for approximating for a new tf:
k = 2;
T = 5;
H = tf(k, [T 1]);
w = logspace(-3,3,1000);

[m,ph] = bode(H,w); 
mv  = squeeze(m);
phv = squeeze(ph);

% ploting the bode diagram using mv and phv vectors:

%magnitude:
figure;
subplot(2,1,1);
semilogx(w,20*log10(mv));
% drawing an approximation
hold on;
semilogx([1e-3 1/5 2 20 100],[0 0 -20 -40 -54]+20*log10(k),'r*-',LineWidth=2);
hold off;

title("Magnitude characteristic");
xlabel('Frequencies \omega (lg)[rad/sec]');
ylabel('|H(j\omega)|^{dB}', 'FontSize', 14);
grid;

%phase:
subplot(2,1,2);
semilogx(w,phv,'b-');
hold on;
semilogx([1e-3 0.02 0.2 2 1000],[0 0 -45 -90 -90],'r*-',LineWidth=2);
hold off
title("Phase characteristic");
xlabel('Frequencies \omega (lg)[rad/sec]');
ylabel('\angle H(j\omega) [deg]', 'FontSize', 14);
grid;

%% Problem 1):

wn = 10;
df = 0.5;
H =tf(1,[1/wn^2 2*df/wn 1]);
figure;
bode(H);
grid;
shg;
% Problem: approximate the magnitude using the cheatsheet
%for smalle freq.<< wn the magnitude approx. 0 dB and
% for high freq.>> wn the magnitude is along an asymptote with
% a slope of -40 dB
%% Aproximating the magnitude
w = logspace(-3,3,1000);
[m, ph] = bode(H,w);
mv  = squeeze(m);
phv = squeeze(ph);

figure;
semilogx(w,20*log10(mv));
hold on;
semilogx([1e-3 wn 100 1000],[0 0 -40 -80],'r*-', LineWidth=2);
title("Magnitude characteristic for second order tf");
xlabel('Frequencies \omega (lg)[rad/sec]');
ylabel('|H(j\omega)|^{dB}', 'FontSize', 14);
hold off;
grid




