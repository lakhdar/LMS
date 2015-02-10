(function (win, ng) {
  'use strict';
  ng.module('app')
   .constant('routes', [
          {
            url: '/',
            config: {
              templateUrl: 'home/home',
              settings: {
              }
            }
          }, {
            url: '/contact',
            config: {
              templateUrl: 'home/contact',
              settings: {
              }
            }
          }, {
            url: '/about',
            config: {
              templateUrl: 'home/about',
              settings: {
              }
            }
          }, {
            url: '/privacy',
            config: {
              templateUrl: 'home/Privacy',
              settings: {
              }
            }
          }, {
            url: '/termsOfUse',
            config: {
              templateUrl: 'home/TermsOfUse',
              settings: {
              }
            }
          }, {
            url: '/FAQ',
            config: {
              templateUrl: 'home/FAQ',
              settings: {
              }
            }
          }, {
            url: '/News',
            config: {
              templateUrl: function (params) {
                var id = win.sessionStorage.getItem("newsCurrentPage") || 1;
                return 'news/Index/' + id;
              },
              settings: {
              }
            }
          }, {
            url: '/News/:id',
            config: {
              templateUrl: function (params) {
                return 'news/Index/' + params.id;
              },
              settings: {
              }
            }
          }, {
            url: '/News/Details/:id',
            config: {
              templateUrl: function (params) { return 'news/Details/' + params.id; },
              settings: {
              }
            }
          }, {
            url: '/Events',
            config: {
              templateUrl: function (params) {
                var id = win.sessionStorage.getItem("eventCurrentPage") || 1;
                return 'Events/Index/' + id;
              },
              settings: {
              }
            }
          }, {
            url: '/Events/:id',
            config: {
              templateUrl: function (params) {
                return 'Events/Index/' + params.id;
              },
              settings: {
              }
            }
          }, {
            url: '/Courses',
            config: {
              templateUrl: function (params) {
                var id = win.sessionStorage.getItem("courseCurrentPage") || 1;
                return 'Course/Index/' + id;
              },
              settings: {
              }
            }
          }, {
            url: '/Courses/:id',
            config: {
              templateUrl: function (params) {
                return 'Course/Index/' + params.id;
              },
              settings: {
              }
            }
          }, {
            url: '/Courses/Catalog',
            config: {
              templateUrl: 'Course/Catalog',
              settings: {
              }
            }
          }, {
            url: '/Courses/Details/:id',
            config: {
              templateUrl: function (params) { return 'Course/Details/' + params.id; },
              settings: {
              }
            }
          }, {
            url: '/admin',
            config: {
              templateUrl: 'app/admin/admin.html',
              settings: {
              }
            }
          }, {
            url: '/login',
            config: {
              templateUrl: 'Account/LoginPartial',
              settings: {
              }
            }
          }
   ]);


})(this, angular)