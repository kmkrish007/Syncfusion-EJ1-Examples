System.register(["./grid/grid.component", "./home/home.component"], function (exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var grid_component_1, home_component_1, rootRouterConfig;
    return {
        setters: [
            function (grid_component_1_1) {
                grid_component_1 = grid_component_1_1;
            },
            function (home_component_1_1) {
                home_component_1 = home_component_1_1;
            }
        ],
        execute: function () {
            exports_1("rootRouterConfig", rootRouterConfig = [
                { path: '', redirectTo: 'home', pathMatch: 'full' },
                { path: 'home', component: home_component_1.HomeComponent },
                { path: 'grid', component: grid_component_1.GridComponent }
            ]);
        }
    };
});
