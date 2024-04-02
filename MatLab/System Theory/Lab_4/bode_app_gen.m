%% Bode magnmitude and phase characteristics calculator
clear all;
% Define the transfer functions:
H_a(1) = zpk([],[-3], 10);                  %a)
H_a(2) = zpk([-70],[-20],0.2);              %b)
H_a(3) = zpk([0],[-7],2);                   %c)
H_a(4) = zpk([],[0 -7],20);                 %d)
H_a(5) = zpk([],[0 -1/7],5/7);              %e)
H_a(6) = zpk([],[-1 -10],75);               %f)
H_a(7) = zpk([-2],[-1/3 -1/2], 2/6);        %g)
H_a(8) = zpk([-1/10],[-1/3 -1/2], 2*10/6);  %h)
H_a(9) = zpk([-2],[-5, -10], 20);           %i)

%Iterating trought them (only used for publishing)
for id = 1:9
H = H_a(id);

% define the freq. boundaries:
% should change line on 118
wmin =-1;
wmax = 3;

% Reading the zeros and the poles:
z = abs(cell2mat(H.Z));
p = abs(cell2mat(H.P));

% Calculating the gain:
k = k_cal(H,z,p);

% Calculating the freq. of the approximation points:
wma = wma_cal(z,p,k, wmin, wmax);

%Calculating the magnitudes of the approx. points:
%Due to the structure of it, wma needs to be also changed when 
% we have zeros/poles in 0
m = zeros(length(wma)-1,1);
[m,wma] = mag_cal(wma,m,k,wmin);

% Ploting the magnitudes and the phases: 
plot_app(H,wma,m);

end
%% Functions:

% Function for calculating the gain:
function k = k_cal(H,z,p)
    % We check for zeros in zero:
    if length(z) ~= 0
        for i = 1:length(z)
            if z(i) == 0
                z_k(i) = 1;
            else
                z_k(i) = z(i);
            end
        end
    else
        z_k = 1;
    end
    
    % We check for poles in zero
    if length(p) ~= 0
        for i = 1:length(p)
            if p(i) == 0
                p_k(i) = 1;
            else
                p_k(i) = p(i);
            end
        end
    else
        p_k = 1;
    end
    
    % We calculater the gain:
    k = H.K*prod(z_k)/prod(p_k);

end

% Function for obtaining wma
% (Doing some magic to get wma matrix with more info)\
% wma has 2 columns
% col1 is the actuall frw. value
% col2 hold info of the slop, can be:  0, 1, -1 
function wma = wma_cal(z,p,k, wmin, wmax)
    % We initialy define wma as [wmin, 0; wmin*10, 0 ;...; wmax, 0]
    aux = wmin:wmax;
    wma = 10.^aux;
    wma = [wma' zeros(length(wma),1)];
    
    %adding zeros and poles to wma
    z = [z ones(length(z),1)];
    p = [p ones(length(p),1)*(-1)];
    zap   = [z; p];
    zap   = sortrows(zap);
    wma = [wma ; zap];
    
    % Sorting wma
    wma = sortrows(wma);
    
    % if we have zeros/poles in 10^n we have to remove the rove above/below
    % so we dont have unneccesary values in wma
    for i= 1:length(wma)-1
        if wma(i,1) == wma(i+1,1)
            if wma(i,2) == 0
                wma = [wma(1:i-1,:); wma(i+1:end,:)];
            else
                 wma = [wma(1:i,:); wma(i+2:end,:)];
            end    
            break
        end
    end
end


% Function for calculating the magnitudes:
function [m,wma] = mag_cal(wma,m,k,wmin)
    coeff = wma(1,2)*20;
    % Checking if there are zeros
    if wma(1,1) == 0
        m(1) = 20*(log10(k))*(abs(wmin)+2);
        wma = wma(2:end,:);
    else
        coeff = 0;
        m(1) = 20*log10(k);
    end
    
    % Calculating the magintudes
    for i = 2:length(wma)
        coeff = coeff + wma(i-1,2)*20;
        m(i) = m(i-1) + coeff*log10(wma(i,1)/wma(i-1,1));

    end
end

% Function for plotting the results:
function plot_app(H,wma,m) 
    
    [m_b,f_b,w_b] = bode(H,{wma(1,1),wma(end,1)});
    
    figure;
    % Ploting the main bode plots
    semilogx(w_b,20*log10(squeeze(m_b)),"b");
    hold all;
    % Ploting the approximated points:
    for i=1:length(m)
        semilogx(wma(i,1),m(i),'ro', 'LineWidth',2);
    end
    % Ploting the approximated line
    semilogx(wma, m, 'r-', "LineWidth",2);
    hold off;
    legend("Bode()", "Approximated");
    title('Magnitude characteristics');
    grid;shg;

end