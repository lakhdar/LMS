(function (window, ng) {
  'use strict';
    ng.module('app')
     .directive('ngEnumarable', [function () {
       return {

         scope: {
           templateId: "=",
           data: "=items",
           caption: "=",
           backurl:"=",
           backtext:"=",
           currenttext: "=",
         },
         template: function (elem, attr) {
          var tmp= $("#"+attr.templateid).html();
          return tmp;
         }
       }
     }])


})(this, angular)
