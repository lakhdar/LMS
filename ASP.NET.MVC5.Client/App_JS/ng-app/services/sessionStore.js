(function (win, ng) {
  'use strict';
  var tsr = window.toastr
  ng.module('app')
   .service('sessionStore', [function () {
     return {
       set: function (key,value) {
         if (key)
           win.sessionStorage.setItem(key, value);
       },
       get: function (key) {
         if (key)
          return  win.sessionStorage.getItem(key);
       } 
     }
   }])

})(this, angular)
