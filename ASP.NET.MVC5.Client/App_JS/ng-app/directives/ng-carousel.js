'use strict';
(function (window, ng) {
    ng.module('app')
     .directive('myCarousel', [function () {
         return function (scope, element, attrs) {
             var params = scope.$eval(attrs.ngCarousel)
             element.carousel(params);
         }
     }])


})(this, angular)
