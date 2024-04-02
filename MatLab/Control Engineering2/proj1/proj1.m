%Transfer Function 
Kf = 3;
Tf = 4;

tr = 10;
sigma = 0.1;

Hf = tf(Kf,conv([1 0],[Tf 1]))

zeta = abs(log(sigma))/sqrt(log(sigma)^2 + pi^2);
wn = 4 / (tr * zeta);
cv = wn / (2 * zeta)
delta_w_b = wn * sqrt(1 - 2 * zeta^2 + sqrt(2 - 4 * zeta^2 + 4 * zeta^4))

H02=tf(wn^2, [1 2*zeta*wn wn^2])
step(H02);

Hr = minreal(1/Hf * H02/(1 - H02))

bode(Hr*Hf)               % deschis = regulator + partea fixa

cvol=db2mag(-5)