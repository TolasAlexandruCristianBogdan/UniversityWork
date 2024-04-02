% Lab 9 (that we skipped because of december the first)
% Negative feedback structures, frequency response, PWM and
% microControllerss
clear all; close all; clc

%% Part 1: initial system:
k = 0.05;   % open loop gain
td = 0.015; % time delay 

% modifications(in simulink):
% step time = 0;
% simulation time = tfin
% salving the data;

% Working directly in script with simulink
tfin =4/135 % simulation time 
sim('system_sl');
t = ans.data.time;
y = ans.data.signals.values;
plot(t,y);
title("Closed loop step response");
xlabel("Time (sec.)"); shg;
grid;


%% Increaing simulation time by a factor of 10 to simulate full stepp response
tfin =4/135*10 % simulation time 
sim('system_sl');
t = ans.data.time;
y = ans.data.signals.values;
plot(t,y);
title("Closed loop step response");
xlabel("Time (sec.)"); shg;
grid;


%% Establish the correct sampling period
Ts = 1e-3; %we choose this value only for better visualisation of the step response
tfin = 0.4;sim('system_sl');
t = ans.data.time;
y = ans.data.signals.values;
plot(t,y);
title("Closed loop step response");
xlabel("Time (sec.)"); shg;
grid;

%% Replacing the reference with a pulse width motulated signal
%Tpwm = ?
% draw the open loop bode diagram read the frequency for -40dB(attenuation)
Hol = tf(k*9e4,[1 135 0], 'iodelay', td);
bode(Hol);shg;grid
% the freq. where the magnitude is attenuated with 40dB is 665 rad/s
w_40 = 665;
% this means:
Tpwm= 1/w_40;

%% Ploting the step and the pwm signal
dc = 63; % duty cycle in precentage
Ts = Tpwm/10; % we need to set this to eliminate the error of the input pwms freq. is not a multiple of the sampling period
sim('system_sl');
t = ans.data.time;
y = ans.data.signals(1).values;
y_pwm = ans.data.signals(2).values;
plot(t,y,t,y_pwm);
title("Closed loop, dc = 60%, Ts = Tpwm/10");
xlabel("Time (sec.)"); shg;grid;
legend('Step reference','PWM reference')

%% Correcting the sampling time so it works with other duty cycle values(not only for values of every ten increments)
dc = 75.4; % duty cycle in precentage
Ts = Tpwm/1000; % we need to set this to eliminate the error of the input pwms freq. is not a multiple of the sampling period
sim('system_sl');
t = ans.data.time;
y = ans.data.signals(1).values;
y_pwm = ans.data.signals(2).values;
plot(t,y,t,y_pwm);
title("Closed loop, dc = 75.4%, Ts = Tpwm/10");
xlabel("Time (sec.)"); shg;grid;
legend('Step reference','PWM reference')

%% Plotting the u_pwm input too
dc = 99; % duty cycle in precentage
Ts = Tpwm/100; % we need to set this to eliminate the error of the input pwms freq. is not a multiple of the sampling period
sim('system_sl');
t = ans.data.time;

y_pwm = ans.data.signals(2).values;
stairs(t,u_pwm, '*');shg;grid;
axis([0 2*Tpwm -0.1 1.1]);


