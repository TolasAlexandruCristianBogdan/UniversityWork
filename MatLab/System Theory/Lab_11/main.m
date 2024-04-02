% Stability analysis off discrete time control structures:
clear; close all; clc

%S1 - Stability analysis depending on k
num = [1 2];
den = [4 -3 -1];
Hp = tf(num,den)

T = 0.2/10;                % sampling period
Hdes = c2d(Hp,T,'zoh')  % open loop discrete time transfer function

figure;
subplot(121);
rlocus(Hp);
title("Continuous-time approach");
text(-8,2,'$H_{des}(s)=\frac{s+2}{(4s+1)(s-1)}$','Interpreter','Latex','FontSize',12);

subplot(122);rlocus(Hdes);title('Discrete-time approach')
text(-0.5,0.6,'$H_{des}(z)=\frac{0.064563 (z-0.6655)}{(z-1.221) (z-0.9512)}$','Interpreter','Latex','FontSize',12)

% Looking on both the discrete and continuous root-graph we can see that in
% the descrete time domain the system remains stable for k from 3.78 to 40.3; 
% the continuous time domain is stable for k from 3 to inf;
% we can observe that the domain for k for which the system remains stable
% is seginificantly reduced from inf -> 40.3 as an upper limit.


%% S2 - Simulating for diferent values of k the step response of the system
k = 16; 
%sampling theorem no longer works for k = 16;
% the system for k from (25.4,27) the system is overdamped
%a solution would be to work with a smaller sampling period
Ho = feedback(k*Hp,1);
figure;
subplot(121)
step(feedback(k*Hdes,1),4);
hold on
step(Ho);
hold off
subplot(122);
pzmap(feedback(k*Hdes,1));

% we tested it for 
% k = 3.77
% k = 16 

%% S3  
Hp = zpk([],[-20 -40],2400);
Ts = 1/300;
Tmax = 1/20; %1/poles coefficients, we need to take the largest
Ct = Tmax/10; % we want 10 samples in each period
Tt = 4*Tmax;

Hdes =c2d(Hp,Ts);
figure;
rlocus(Hdes)
% from rlocus for k from (0, 15.7) the closed loop is asimptotically stable
% for k from (0, 0.0396), Overdamped system (two real and distinctived poles)


figure;
k = 0.03; % k from (0, 0.396)
subplot(121)
step(feedback(k*Hdes,1),1)
title("step response for k = 0.03, Overdamped system");
subplot(122)
pzmap(feedback(k*Hdes,1))

%%
figure;
k = 0.0396; % k = 0.396
subplot(121)
step(feedback(k*Hdes,1),1)
title("step response for k = 0.0396, Crtitically damped system");
subplot(122)
pzmap(feedback(k*Hdes,1))

%%
figure;
k = 5; % k from (0.396 , 15.7)
subplot(121)
step(feedback(k*Hdes,1),1)
title("step response for k from (0.396 , 15.7), Underdamped system");
subplot(122)
pzmap(feedback(k*Hdes,1))

%%
figure;
k = 15.7; % k = 15.7 (stability limit) undamped system
subplot(121)
step(feedback(k*Hdes,1),0.4)
title("step response for k = 15.7, Unddamped system");
subplot(122)
pzmap(feedback(k*Hdes,1))

