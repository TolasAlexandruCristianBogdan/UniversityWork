%% Reglare in cascada

%Impartim un proces in 2 (Hf1 si Hf2)

%vrem sa facem un regulator pt Hf2 pentru ca daca apare o perturbatie sa nu
%afecteze restul procesului 

%in bucla interna e procesul rapid, pt ca daca il punem pe cel lent , se va
%astepta dupa el , vrem sa sse execute cel rapid de multe ori pana se
%executa cel lent o data

%Daca luam feedbackul din partea interna,va tine cont doar de Hf2 (cuHR2)
%HR1 controleaza tot sistemul 

%Partea interna cu tot cu sumator se ppoate nota cu Hoi
%Hoi=HR2*Hf2/1+HR2*Hf2

%reject a step disturbance = neglijam eroarea stationara, facem PI

%% Exercitiile din lab
clear all;close all;clc

%Transfer function from the lab 
num_f1=2.4;
den_f1=conv([0.5 1],[50 1]);
Hf1=tf(num_f1,den_f1)

num_f2=8.6;
den_f2=conv([0.01 1],[0.6 1])
Hf2=tf(num_f2,den_f2)

%H magnitude 
Ts1=0.01;   %Alegem timpul cel mai mic 
num_mag=1;
den_mag=conv([2*Ts1 0],[Ts1 1]);
Hd_magn = tf(num_mag,den_mag);

HR2 = minreal(Hd_magn/Hf2)
Hd1 = series(Hf2, HR2)
H01 = feedback(Hd1, 1)

%H symmetrict
Ts2=0.52;
num_sym=[4*Ts2 1];
den_sym=conv([8*Ts2^2 0 0],[Ts2 1]);
Hd_sym=tf(num_sym,den_sym)

num_f=2.4;
den_f=conv([Ts2 1],[50 1]);
Hf=tf(num_f,den_f)

HR1 = minreal(Hd_sym/Hf)

[20.03 10.03 0.1926]



