Fs = 200000;  %Sampling freq. 
Ts = 1/Fs; % Sampling period

f = 1e3;   %Freq. of the generated sin
w = 2*pi*f; 

A = cos(w*Ts);
B = -sin(w*Ts);

y(1) = B;
y(2) = 0;

n = Fs/f; %numbers of samples for 1 period of the sinewave

for k=3:4*n
    y(k) = 2*cos(w*Ts)*y(k-1)-y(k-2);
end

t = 0:4*n-1;
t = t*Ts;
plot(t,y)

%%

min = -50;
max = 5000;

(max - min)/4095


y = 3.7*y
