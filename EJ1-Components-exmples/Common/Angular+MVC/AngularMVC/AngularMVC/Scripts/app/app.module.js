System.register(["@angular/core", "@angular/platform-browser", "@angular/router", "@angular/forms", "@angular/http", "ej-angular2", "./app.component", "./home/home.component", "./grid/grid.component", "./app.routes"], function (exports_1, context_1) {
    "use strict";
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __moduleName = context_1 && context_1.id;
    var core_1, platform_browser_1, router_1, forms_1, http_1, ej_angular2_1, app_component_1, home_component_1, grid_component_1, app_routes_1, CustomErrorHandler, AppModule;
    return {
        setters: [
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (platform_browser_1_1) {
                platform_browser_1 = platform_browser_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            },
            function (forms_1_1) {
                forms_1 = forms_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            },
            function (ej_angular2_1_1) {
                ej_angular2_1 = ej_angular2_1_1;
            },
            function (app_component_1_1) {
                app_component_1 = app_component_1_1;
            },
            function (home_component_1_1) {
                home_component_1 = home_component_1_1;
            },
            function (grid_component_1_1) {
                grid_component_1 = grid_component_1_1;
            },
            function (app_routes_1_1) {
                app_routes_1 = app_routes_1_1;
            }
        ],
        execute: function () {
            core_1.enableProdMode();
            CustomErrorHandler = (function () {
                function CustomErrorHandler() {
                }
                CustomErrorHandler.prototype.call = function (error, stackTrace, reason) {
                    if (stackTrace === void 0) { stackTrace = null; }
                    if (reason === void 0) { reason = null; }
                    console.log(error + "\n" + stackTrace);
                };
                CustomErrorHandler.prototype.handleError = function (error) {
                    console.log(error);
                };
                return CustomErrorHandler;
            }());
            AppModule = (function () {
                function AppModule() {
                }
                AppModule = __decorate([
                    core_1.NgModule({
                        imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, http_1.HttpModule, ej_angular2_1.EJAngular2Module.forRoot(), router_1.RouterModule.forRoot(app_routes_1.rootRouterConfig, { useHash: true })],
                        declarations: [app_component_1.AppComponent, home_component_1.HomeComponent, grid_component_1.GridComponent],
                        bootstrap: [app_component_1.AppComponent]
                    })
                ], AppModule);
                return AppModule;
            }());
            exports_1("AppModule", AppModule);
        }
    };
});
