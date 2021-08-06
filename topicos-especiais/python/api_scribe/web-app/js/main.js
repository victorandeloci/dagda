const cE = React.createElement;

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

  var apiUrl = window.location.host;

  if(document.getElementById('loginForm')){
    document.getElementById('loginForm').addEventListener('submit', function(e){

      e.preventDefault();

      let mail = document.querySelector('#loginForm input[name="mail"]').value;
      let pass = document.querySelector('#loginForm input[name="password"]').value;

      let formData = new FormData();
         formData.append('email', mail);
         formData.append('password', pass);

      fetch('/api/login/', {
        method: 'POST',
        body: formData
      })
      .then(function(response) {
        return response.json();
      })
      .then(function(json) {
        if (json.status) {
          localStorage.setItem('owner_id', json.content.id);
          window.location.href = '/app';
        }
      });
    });

    if(document.getElementById('register')){
      document.getElementById('register').addEventListener('click', function(){
        window.location.href = '/register';
      });
    }
  }

  if(document.getElementById('registerForm')){
    document.getElementById('registerForm').addEventListener('submit', function(e){

      e.preventDefault();

      let mail = document.querySelector('#registerForm input[name="mail"]').value;
      let pass = document.querySelector('#registerForm input[name="password"]').value;

      let formData = new FormData();
         formData.append('email', mail);
         formData.append('password', pass);

      fetch('/api/register_user/', {
        method: 'POST',
        body: formData
      })
      .then(function(response) {
        return response.json();
      })
      .then(function(json) {
        if (json.status) {
          window.location.href = 'http://127.0.0.1:8000/';
        }
      });
    });
  }

  if (document.getElementById('apisContainer')) {

    fetch('/api/get_apis/?owner_id=' + localStorage.getItem('owner_id'), {
      method: 'GET'
    })
    .then(function(response) {
      return response.json();
    })
    .then(function(json) {
      console.log(json);
      if (json.status) {

        apis = [];
        json.content.forEach((api, i) => {
          block = cE(
            'div',
            { className: 'api-block', key: 'id_' + api.id },
            cE(
              'h3',
              null,
              api.name
            ),
            cE(
              'div',
              {
                className: 'actions',

              },
              cE(
                'button',
                {
                  className: 'newAction',
                  onClick: () => {
                    localStorage.setItem('api_id', api.id);
                    window.location.href = '/register_action';
                  }
                },
                cE(
                  'span',
                  { className: 'material-icons' },
                  'add'
                )
              ),
              cE(
                'button',
                {
                  className: 'exportJsonLink',
                  onClick: () => {
                    window.open('/api/export_apis/?owner_id=' + localStorage.getItem('owner_id'), '_blank').focus();
                  },
                  title: 'Exportar'
                },
                cE(
                  'span',
                  { className: 'material-icons' },
                  'download'
                )
              )
            )
          );
          apis.push(block);
        });

        apis.push(cE(
          'div',
          {
            className: 'api-block',
            key: 'id_new',
            onClick: () => {
              window.location.href = '/register_api';
            }
          },
          cE(
            'h3',
            null,
            cE(
              'span',
              { className: 'material-icons' },
              'add'
            )
          )
        ));

        ReactDOM.render(cE(
          'div',
          { className: 'container' },
          apis
        ), document.querySelector('#apisContainer'));

      }
    });

  }

  if (document.getElementById('apiForm')) {
    document.getElementById('apiForm').addEventListener('submit', function(e) {

      e.preventDefault();

      let name = document.querySelector('#apiForm input[name="name"]').value;

      let formData = new FormData();
       formData.append('name', name);
       formData.append('owner_id', localStorage.getItem('owner_id'));

      fetch('/api/register_api/', {
        method: 'POST',
        body: formData
      })
      .then(function(response) {
        return response.json();
      })
      .then(function(json) {
        if (json.status) {
          window.location.href = '/app';
        }
      });

    });
  }

  if (document.getElementById('actionForm')) {
    document.getElementById('actionForm').addEventListener('submit', function(e) {

      e.preventDefault();

      let name = document.querySelector('#actionForm input[name="name"]').value;
      let path = document.querySelector('#actionForm input[name="path"]').value;
      let parameters = document.querySelector('#actionForm input[name="parameters"]').value;
      let response = document.querySelector('#actionForm input[name="response"]').value;

      let formData = new FormData();
       formData.append('name', name);
       formData.append('path', path);
       formData.append('parameters', parameters);
       formData.append('response', response);
       formData.append('api_id', localStorage.getItem('api_id'));

      fetch('/api/create_action/', {
        method: 'POST',
        body: formData
      })
      .then(function(response) {
        return response.json();
      })
      .then(function(json) {
        if (json.status) {
          window.location.href = '/app';
        }
      });

    });
  }
});
