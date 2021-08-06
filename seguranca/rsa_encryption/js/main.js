function docReady(fn) {
  // see if DOM is already available
  if (document.readyState === 'complete' || document.readyState === 'interactive') {
    // call on next available tick
    setTimeout(fn, 1);
  } else {
    document.addEventListener('DOMContentLoaded', fn);
  }
}

docReady(function() {
	
	var site_url = window.location.href;

	let alvo = document.getElementById('alvo');
	let encrypted = document.getElementById('encrypted');
	let decrypted = document.getElementById('decrypted');
	let varsContainer = document.getElementById('vars');
	let send = document.getElementById('send');

	send.addEventListener('click', function(){
		let message = alvo.value;

		let request = new XMLHttpRequest();
		  request.open('GET', site_url + 'encryption.php?message=' + message , true);
		  request.onload = function() {
		    if (this.status >= 200 && this.status < 400) {

		      let resp = this.response;
          let result = JSON.parse(resp);

          encrypted.innerHTML = result.cryptedMessage;
          decrypted.innerHTML = result.decryptedMessageData;

          let varsList = '<ul>' +
            '<li>P: ' + result.vars['P'] + '</li>' +
            '<li>Q: ' + result.vars['Q'] + '</li>' +
            '<li>N: ' + result.vars['N'] + '</li>' +
            '<li>Z: ' + result.vars['Z'] + '</li>' +
            '<li>D: ' + result.vars['D'] + '</li>' +
            '<li>E: ' + result.vars['E'] + '</li>' +
          '</ul>';

          varsContainer.innerHTML = varsList;

		    } else {
		      console.log('Internal Server Error!\n' + this.response);
		    }
		  };

		  request.onerror = function() {
		    console.log('Request error...');
		  };

		  request.send();
	});

});
