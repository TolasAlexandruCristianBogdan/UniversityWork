function ap1(H,f)
T = 1/f; % the period of the input sinewave
w = 2*pi*f; % the freq 

t = 0:T/50:12*T; % simulation time basis (depends on T!!!)
u = sin(w*t); % the input signal

y = lsim(H,u,t); % storeing (not just ploting) the output signal from the simulation


ymin = min(y(4*50:end,1));
ymax = max(y(4*50:end,1));

A = abs(ymax-ymin)/2;

if (A >= 1/sqrt(2))
    effect_str = 'The signal is passed.'
else
    effect_str = 'The signal is attenuated.'
end
    text(10,1/sqrt(2), effect_str);

plot(t,u,'r',t,y,'b');

title(['Sinewave response of FOE, with a freq. f = ', num2str(f), 'Hz']);
text(t(3*50), ymax*1.1,['A_s_s = ', num2str(A)], 'FontSize',16);
text(t(10),0.789, effect_str,'FontSize',16);
yline(1/sqrt(2),'g');
legend('Input signal', 'Output signal');
grid;
shg
end