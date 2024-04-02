%% Generating the plot of a response to a sine signal of a tf

close all; clear all; clc;
% the circuit parameters
R1 = 1e3;
R2 = R1;
C1 = 1e-6;

f = 1e3; % the freq. in Hz of the input sinewave
T = 1/f; % the period of th einput sinewave
w = 2*pi*f; % the freq 

t = 0:T/50:12*T; % simulation time basis (depends on T!!!)

H = tf(-R2/R1, [R2*C1 1]); % creating the tf
u = sin(w*t); % the input signal

lsim(H,u,t) % linear simulation of the response

%% Ploting it more beautifully
y = lsim(H,u,t); % storeing (not just ploting) the output signal from the simulation

plot(t,u,'r',t,y,'b');
legend('Input signal', 'Output signal');
title(['Sinewave response of FOE, with a freq. f = ', num2str(f), 'Hz']);
grid;
shg


%% we will be focusing on the amplitude difference on the following laboratos

% write a function ap1 that has a tf as a parameter and the freq. of an input signal as
% parameter that displays the graph already plotted.

%0.707 if -> the signal is passed/attenuated
ap1(H,300);