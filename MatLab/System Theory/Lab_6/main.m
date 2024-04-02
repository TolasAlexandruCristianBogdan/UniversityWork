%% Lab 6. 
close all; clear; clc;

% Defining the transfer function
tau = 0.2;

H_ol = tf(12,[1 5 0], "IOdelay", tau);

% Ploting the bode plot for H_ol:

wmin = 1e-1;
wmax = 1e2 ;
w = logspace(log10(wmin),log10(wmax));
[m,f] = bode(H_ol,w);

m = squeeze(m);
f = squeeze(f);

figure
subplot(2,1,1);
semilogx(w,20*log10(m),'b');
title("Bode diagram", 'FontSize',18);
ylabel("Magnitude (dB)",'FontSize',14)
axis([wmin wmax -60 40])
grid; 

subplot(2,1,2);
semilogx(w,f,'b');
ylabel("Phase(deg)",'FontSize',14);
xlabel("Frequency (rad/s)",'FontSize',14)
grid; shg;

% Windowing the phase characterisitc around -180 degrees
axis([wmin wmax -270 0]);
yticks([-270 -180 -90 0]);


% The cutoff freq. is :
wc = 2.223;

% Pointing out the cutoff freq.
handles = findobj(gcf, 'Type', 'axes');
axes(handles(2))
hold on
plot(wc,0,'x','LineWidth', 3, 'Color','black');
text(wc,0,"   \omega_c","FontSize",20)
hold off

% Reading the phase at cutoff freq.
phase_wc = -139.5;

% Ploting the phase margin
handles = findobj(gcf, 'Type', 'axes');
axes(handles(2))
hold on
yline(-180,'--')
plot([wc wc],[-180 phase_wc]', 'LineWidth',3, 'Color','magenta');
plot(wc,phase_wc,'^','LineWidth',3, 'Color','magenta')
text(wc, phase_wc +(-180-phase_wc)/2,"  \gamma_k = " + num2str(abs(-180-phase_wc)) + "\circ", 'FontSize', 16)
hold off
% Reading the phase characteristic
w_pi = 4.3;

% Ploting the phase characteristic
handles = findobj(gcf, 'Type', 'axes');
axes(handles(1))
hold on
plot(w_pi,-180,'x','LineWidth', 3, 'Color','black');
text(w_pi,-180-5,"   \omega_\pi","FontSize",20)
hold off

% Reading the magnitude margin
mk = -7.4;

% Ploting the magnitude margin
handles = findobj(gcf, 'Type', 'axes');
axes(handles(2))
hold on
yline(0,'--')
plot([w_pi w_pi],[mk 0]', 'LineWidth',3, 'Color','magenta');
plot(w_pi,mk,'v','LineWidth',3, 'Color','magenta')
text(w_pi, -5,"  m_k = " + num2str(mk) + "dB", 'FontSize', 16)
hold off

% Zooming for better illustration:
axis([1 10 -60 40])
handles = findobj(gcf, 'Type', 'axes');
axes(handles(2))
axis([1 10 -270 0])
