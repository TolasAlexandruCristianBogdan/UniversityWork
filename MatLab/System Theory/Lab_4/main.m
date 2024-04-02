%% Example i)
%H = tf(20*[1 2], conv([1 5],[1 10]))
H = zpk([-2],[-5, -10], 20);
zeros = cell2mat(H.Z);
poles = cell2mat(H.P);

%Calculating the gain after changeing the form:
k = H.K*prod(cell2mat(H.Z)*(-1))/prod(poles*(-1));

wma = [0.1 2 5 10 1e2 1e3];
m1  = 20*log10(k);
m2  = m1 + 0*log10(2/0.1);
m3  = m2 + (+20)*log10(5/2);
m4  = m3 + 0* log10(10/5);
m5  = m4 + -20*log10(100/10);
m6  = m5 + -20*log10(1e3/1e2);

ma = [m1 m2 m3 m4 m5 m6];
[m,f,w] = bode(H);

%Verificare
semilogx(w,20*log10(squeeze(m)),"b");
hold on;
semilogx(wma(1),m1,'ro', 'LineWidth',2);
semilogx(wma(2),m2,'ro', 'LineWidth',2);
semilogx(wma(3),m3,'ro', 'LineWidth',2);
semilogx(wma(4),m4,'ro', 'LineWidth',2);
semilogx(wma(5),m5,'ro', 'LineWidth',2);
semilogx(wma(6),m6,'ro', 'LineWidth',2);
semilogx(wma, ma, 'r-', "LineWidth",2);
title('Magnitude characteristics');
xlabel('\omega (rad/sec)');ylabel('|H(j\omega)|^dB');
text(1e2,5,'$$H(s)=20\frac{10s+1}{(s+10)(s+5)}$$', 'Interpreter', 'latex', FontSize=14);
% From here comes the gain calculation:
text(1e2, -5,'$$H(s)=\frac{20*10(s+1/10)}{10*5(s/10+1)(s/5+1)}$$', 'Interpreter', 'latex', FontSize=14)

grid; shg;
hold off;

%% Example f)
H = zpk([],[1 10],75);
zeros = cell2mat(H.Z);
poles = cell2mat(H.P);
k = H.K*prod(cell2mat(H.Z)*(-1))/prod(poles*(-1));
wma = [1e-2 1e-1 1 10 1e2 1e3];
m0  = 20*log10(k);
m1  = m0 + 0*log10(1e-1/1e-2);
m2  = m1 + 0*log10(1/0.1);
m3  = m2 + -20*log10(10/1);
m4  = m3 + -40*log10(1e2/10);
m5  = m4 + -40*log10(1e3/1e2);


ma = [m0 m1 m2 m3 m4 m5];
[m,f,w] = bode(H,{wma(1),wma(end)});

%Verificare
semilogx(w,20*log10(squeeze(m)),"b");
hold on;
semilogx(wma(1),m0,'ro', 'LineWidth',2);
semilogx(wma(2),m1,'ro', 'LineWidth',2);
semilogx(wma(3),m2,'ro', 'LineWidth',2);
semilogx(wma(4),m3,'ro', 'LineWidth',2);
semilogx(wma(5),m4,'ro', 'LineWidth',2);
semilogx(wma(6),m5,'ro', 'LineWidth',2);
semilogx(wma, ma, 'r-', "LineWidth",2);
title('Magnitude characteristics');
xlabel('\omega (rad/sec)');ylabel('|H(j\omega)|^dB');
grid; shg;
hold off;
