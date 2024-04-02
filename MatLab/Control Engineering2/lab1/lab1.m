%%
Ts = 0.1;
Ts1 = 1;
Ts2 = 2;
H = tf(15,conv([1 0],[1 5]))
%Ts = 0.1
Hzoh = c2d(H,Ts,'zoh');
Ht = c2d(H,Ts,'tustin');
figure;
step(feedback(Hzoh,1));
hold
step(feedback(Ht,1));
legend('zoh','tustin');
%Ts1 = 1;
Hzoh1 = c2d(H,Ts1,'zoh');
Ht1 = c2d(H,Ts1,'tustin');
figure;
step(feedback(Hzoh1,1));
hold
step(feedback(Ht1,1));
legend('zoh','tustin');
%Ts2 = 2;
Hzoh2 = c2d(H,Ts2,'zoh');
Ht2 = c2d(H,Ts2,'tustin');
figure;
step(feedback(Hzoh2,1));
hold
step(feedback(Ht2,1));
legend('zoh','tustin');
%%
