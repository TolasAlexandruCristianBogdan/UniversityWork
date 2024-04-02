%% Case 1

k = 1;
tm = 0;
Hol = tf(k*9e4, [1 135 0], 'iodelay', tm); % transfer funtion definition

N = nyquistplot(Hol);   % getting the nyquist plot for the open loop tf
setoptions(N, 'ShowFullContour', 'off');    % the options for the nyquist diagram
grid;

axis([-3.5 1.5 -3 2.5]);    % zoom on the axis
shg;

%% The realationship between Peak Magnitude and Overshoot(Attempt)

zeta = .5:.001:0.707;   % zeta should be between (.5 and 1/sqrt(2))

overshoot = exp(-pi*zeta ./ sqrt(1 - zeta.^2)); % the plain formula of the overshoot but written in exp form
Mp = 1./(2 .* zeta .* sqrt(1 - zeta.^2)); % the plain formula for the magnitude

overshoot = overshoot * 100;
Mp = Mp * 10;


plot(overshoot, Mp);
grid;

xlabel('Overshoot[%]');
ylabel('Mp[Peak Magnitude]');
title('The relationship between the Overshoot and Peak Magnitude');

figure
MpdB = 20*log10(Mp);
zeta = 20*log10(overshoot);

plot(overshoot, Mp, 'r');
grid;



xlabel('Overshoot[%]');
ylabel('Mp[dB]');
title('The relationship between the Overshoot and Peak Magnitude in dB');

%% 

MpdB = 7.2;
Mp = 10^(MpdB/20);
roots([-4 0 4 -1/Mp^2])

df = .2239;

% wn = ?
% 20*log10(1/2/df);

wn = 400;

sigma = exp(-df*pi/sqrt(1 - df^2)) * 100;

ts = 4/df/wn; % settling time

%% 


k = 1;
tm = 0;
Hol = tf(k*9e4, [1 135 0], 'iodelay', tm); % transfer funtion definition

N = nyquistplot(Hol);   % getting the nyquist plot for the open loop tf
setoptions(N, 'ShowFullContour', 'off');    % the options for the nyquist diagram
grid;

axis([-3.5 1.5 -3 2.5]);    % zoom on the axis
shg;


r = 0:.001:2*pi;

hold on;

plot(Mp/(Mp^2-1) * sin(r) - Mp^2/(Mp^2-1), cos(r) * Mp/(Mp^2-1), 'r--');

hold off;
