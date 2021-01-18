/// <reference path="Scripts/typings/jquery/jquery.d.ts" />
/// <reference path="Scripts/typings/ej/ej.web.all.d.ts" />
$(function () {
    $("#datep").ejDatePicker({});
    var dateFormat = "{0:" + ej.preferredCulture()["calendars"]["standard"]["patterns"]["d"] + "}";
    var columnTemplate = "<script type=\"text/x-jsrender\" id=\"customColumnTemplate\">\n        <div style='height:20px;' unselectable='on'>\n            {{if hasChildRecords}}<div class='intend' style='height:1px; float:left; width:{{:level*20}}px; display:inline-block;'></div>\n            {{else !hasChildRecords}}\n               <div class='intend' style='height:1px; float:left; width:{{:(level)*20}}px; display:inline-block;'></div>\n            {{/if}}\n                <div class='{{if expanded}}e-treegridexpand {{else hasChildRecords}}e-treegridcollapse {{/if}} {{if level===4}}e-doc{{/if}}' style='height:20px;width:30px;margin:auto;float:left;margin-left:10px;\n                   style=' float left;display:inline-block; unselectable='on'></div>\n\n            <div class='e-cell' style='display:inline-block;width:100%' unselectable='on'>{{:#data['taskName']}}</div>\n        </div>\n    </script>";
    // creates a task model based on task class instances
    var treeGridModel = createTaskModel();
    // creates a model based on plain task objects
    var plaintObjectTreeModel = createPlainObjectTaskModel();
    // instantiate and initialize tree grid
    var treeGrid = new ej.TreeGrid($("#treeGrid"), {
        dataSource: [],
        childMapping: "subtasks",
        allowColumnResize: true,
        isResponsive: true,
        rowHeight: 30,
        columns: [
            // working case 
            //{ field: "taskName", headerText: "Task Name", isTemplateColumn: false, template: columnTemplate },
            // error case !!!
            { field: "taskName", headerText: "Task Name", isTemplateColumn: true, template: columnTemplate },
            { field: "startDate", headerText: "Start Date", format: dateFormat },
            { field: "endDate", headerText: "End Date", format: dateFormat },
            //{ field: "duration", headerText: "Duration" },
            { field: "duration", headerText: "Duration" },
            { field: "progress", headerText: "Progress" },
            { field: "taskID", headerText: "Task Id", width: 45 },
        ]
    });
    // gt treegrid instance
    var treeGridObj = $("#treeGrid").data("ejTreeGrid");
    // error case !!!
    // populate tree grig with task class objects
    treeGridObj.setModel({ "dataSource": treeGridModel }, false);
    // working case 
    // populate tree grig with task class objects
    //treeGridObj.setModel({ "dataSource": plaintObjectTreeModel }, false);
});
function createPlainObjectTaskModel() {
    return [
        {
            taskID: 1,
            taskName: "Planning",
            startDate: new Date("02/03/2017"),
            endDate: new Date("02/07/2017"),
            progress: 100,
            duration: 5,
            priority: "Normal",
            approved: false,
            subtasks: [
                {
                    taskID: 2,
                    taskName: "Plan timeline",
                    startDate: new Date("02/03/2017"),
                    endDate: new Date("02/07/2017"),
                    duration: 5,
                    progress: 100,
                    priority: "Normal",
                    approved: false
                },
                {
                    taskID: 3,
                    taskName: "Plan budget",
                    startDate: new Date("02/03/2017"),
                    endDate: new Date("02/07/2017"),
                    duration: 5,
                    progress: 100,
                    approved: true
                },
                {
                    taskID: 4,
                    taskName: "Allocate resources",
                    startDate: new Date("02/03/2017"),
                    endDate: new Date("02/07/2017"),
                    duration: 5,
                    progress: 100,
                    priority: "Critical",
                    approved: false
                },
                {
                    taskID: 5,
                    taskName: "Planning complete",
                    startDate: new Date("02/07/2017"),
                    endDate: new Date("02/07/2017"),
                    duration: 0,
                    progress: 0,
                    priority: "Low",
                    approved: true
                }
            ]
        },
        {
            taskID: 6,
            taskName: "Design",
            startDate: new Date("02/10/2017"),
            endDate: new Date("02/14/2017"),
            duration: 3,
            progress: 86,
            priority: "High",
            approved: false,
            subtasks: [
                {
                    taskID: 7,
                    taskName: "Software Specification",
                    startDate: new Date("02/10/2017"),
                    endDate: new Date("02/12/2017"),
                    duration: 3,
                    progress: 60,
                    priority: "Normal",
                    approved: false
                },
                {
                    taskID: 8,
                    taskName: "Develop prototype",
                    startDate: new Date("02/10/2017"),
                    endDate: new Date("02/12/2017"),
                    duration: 3,
                    progress: 100,
                    priority: "Critical",
                    approved: false
                },
                {
                    taskID: 9,
                    taskName: "Get approval from customer",
                    startDate: new Date("02/13/2017"),
                    endDate: new Date("02/14/2017"),
                    duration: 2,
                    progress: 100,
                    approved: true
                },
                {
                    taskID: 10,
                    taskName: "Design Documentation",
                    startDate: new Date("02/13/2017"),
                    endDate: new Date("02/14/2017"),
                    duration: 2,
                    progress: 100,
                    approved: true
                },
                {
                    taskID: 11,
                    taskName: "Design complete",
                    startDate: new Date("02/14/2017"),
                    endDate: new Date("02/14/2017"),
                    duration: 0,
                    progress: 0,
                    priority: "Normal",
                    approved: true
                }
            ]
        }
    ];
}
function createTaskModel() {
    var treeGridModel = [];
    var newTask = new Task({ taskID: 1, taskName: "Planning (from Task model)", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 100, progress: 5, priority: "Normal", approved: false });
    newTask.subtasks.push({ taskID: 2, taskName: "Plan timeline", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, priority: "Normal", approved: false });
    newTask.subtasks.push({ taskID: 3, taskName: "Plan budget", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, approved: true });
    newTask.subtasks.push({ taskID: 4, taskName: "Allocate resources", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, priority: "Critical", approved: false });
    newTask.subtasks.push({ taskID: 5, taskName: "Planning complete", startDate: new Date("02/07/2017"), endDate: new Date("02/07/2017"), duration: 0, progress: 0, priority: "Low", approved: true });
    treeGridModel.push(newTask);
    newTask = new Task({ taskID: 6, taskName: "Design", startDate: new Date("02/10/2017"), endDate: new Date("02/14/2017"), duration: 3, progress: 86, priority: "High", approved: false });
    newTask.subtasks.push({ taskID: 7, taskName: "Software Specification", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: 60, priority: "Normal", approved: false });
    newTask.subtasks.push({ taskID: 8, taskName: "Develop prototype", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: 100, priority: "Critical", approved: false });
    newTask.subtasks.push({ taskID: 9, taskName: "Get approval from customer", startDate: new Date("02/13/2017"), endDate: new Date("02/14/2017"), duration: 2, progress: 100, approved: true });
    newTask.subtasks.push({ taskID: 10, taskName: "Design Documentation", startDate: new Date("02/13/2017"), endDate: new Date("02/14/2017"), duration: 2, progress: 100, approved: true });
    treeGridModel.push(newTask);
    return treeGridModel;
}
var Task = /** @class */ (function () {
    function Task(newTask) {
        this._subtasks = [];
        this._taskID = newTask.taskID;
        this._taskName = newTask.taskName;
        this._startDate = newTask.startDate;
        this._endDate = newTask.endDate;
        this._duration = newTask.duration;
        this._progress = newTask.progress;
        this._priority = newTask.priority;
        this._approved = newTask.approved;
        this._subtasks = [];
    }
    Object.defineProperty(Task.prototype, "taskName", {
        get: function () {
            return this._taskName;
        },
        set: function (value) {
            this._taskName = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "taskID", {
        get: function () {
            return this._taskID;
        },
        set: function (value) {
            this._taskID = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "startDate", {
        get: function () {
            return this._startDate;
        },
        set: function (value) {
            this._startDate = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "endDate", {
        get: function () {
            return this._endDate;
        },
        set: function (value) {
            this._endDate = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "duration", {
        get: function () {
            return this._duration;
        },
        set: function (value) {
            this._duration = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "progress", {
        get: function () {
            return this._progress;
        },
        set: function (value) {
            this._progress = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "priority", {
        get: function () {
            return this._priority;
        },
        set: function (value) {
            this._priority = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "approved", {
        get: function () {
            return this._approved;
        },
        set: function (value) {
            this._approved = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Task.prototype, "subtasks", {
        get: function () {
            return this._subtasks;
        },
        set: function (value) {
            this._subtasks = value;
        },
        enumerable: false,
        configurable: true
    });
    return Task;
}());
//# sourceMappingURL=app.js.map