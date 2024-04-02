function getFibonacci(n) {
    var fibonacciSeries = [];
    var a = 0, b = 1;

    
    while (a <= n) {
        fibonacciSeries.push(a);
        var next = a + b;
        a = b;
        b = next;
    }

    return fibonacciSeries;
}

// Example
var limit = 100; // Set the limit for the Fibonacci series
var fibonacciNumbers = getFibonacci(limit);
console.log(fibonacciNumbers); // Output the generated Fibonacci series