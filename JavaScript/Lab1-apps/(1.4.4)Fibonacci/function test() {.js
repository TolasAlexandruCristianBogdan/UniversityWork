function test() {
    console.log(getFibonacci(2).toString() === [1, 1].toString() ? "Passed" : "Failed");
    console.log(getFibonacci(5).toString() === [1, 1, 2, 3, 5].toString() ? "Passed" : "Failed");
    console.log(getFibonacci() === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci('abc') === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci(-1) === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci(11) === "not allowed" ? "Passed" : "Failed");
  }
  
  test();
  
  (function() {
    console.log(getFibonacci(2).toString() === [1, 1].toString() ? "Passed" : "Failed");
    console.log(getFibonacci(5).toString() === [1, 1, 2, 3, 5].toString() ? "Passed" : "Failed");
    console.log(getFibonacci() === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci('abc') === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci(-1) === "not allowed" ? "Passed" : "Failed");
    console.log(getFibonacci(11) === "not allowed" ? "Passed" : "Failed");
  })();
  
  console.log("Re-running tests:");
  test();