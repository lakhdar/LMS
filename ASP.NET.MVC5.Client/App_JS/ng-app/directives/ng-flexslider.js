'use strict';
(function (window, ng) {
    

    angular.module('app')
  .directive('myFlexslider', [function () {
      return function (scope, element, attr) {
          setTimeout(function () {
              element.flexslider({
                  animation: "fade"
              });
          })
      };
  }]);


})(this, angular)
