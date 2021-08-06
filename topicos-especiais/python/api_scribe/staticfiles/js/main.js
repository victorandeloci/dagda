function docReady(fn) {
  // see if DOM is already available
  if (document.readyState === 'complete' || 
      document.readyState === 'interactive') {
    // call on next available tick
    setTimeout(fn, 1);
  } else {
    document.addEventListener('DOMContentLoaded', fn);
  }
}

docReady(function() {
  console.log("Eu sou o homem de ferro ou batman, você que escolhe!");

});