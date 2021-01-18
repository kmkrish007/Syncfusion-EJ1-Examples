/// <reference path="Scripts/typings/jquery/jquery.d.ts" />
/// <reference path="Scripts/typings/ej/ej.web.all.d.ts" />

$(function () {
    $("#datep").ejDatePicker({});

    var dateFormat = "{0:" + ej.preferredCulture()["calendars"]["standard"]["patterns"]["d"] + "}";

    const columnTemplate = `<script type="text/x-jsrender" id="customColumnTemplate">
        <div style='height:20px;' unselectable='on'>
            {{if hasChildRecords}}<div class='intend' style='height:1px; float:left; width:{{:level*20}}px; display:inline-block;'></div>
            {{else !hasChildRecords}}
               <div class='intend' style='height:1px; float:left; width:{{:(level)*20}}px; display:inline-block;'></div>
            {{/if}}
                <div class='{{if expanded}}e-treegridexpand {{else hasChildRecords}}e-treegridcollapse {{/if}} {{if level===4}}e-doc{{/if}}' style='height:20px;width:30px;margin:auto;float:left;margin-left:10px;
                   style=' float left;display:inline-block; unselectable='on'></div>

            <div class='e-cell' style='display:inline-block;width:100%' unselectable='on'>{{:#data['taskName']}}</div>
        </div>
    </script>`;

    // creates a task model based on task class instances
    var treeGridModel: Task[] = createTaskModel();

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
    var treeGridModel: Task[] = [];


    var newTask = new Task({ taskID: 1, taskName: "Planning (from Task model)", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 100, progress: 5, priority: "Normal", approved: false } as Task);
    newTask.subtasks.push({ taskID: 2, taskName: "Plan timeline", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, priority: "Normal", approved: false } as Task);
    newTask.subtasks.push({ taskID: 3, taskName: "Plan budget", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, approved: true } as Task);
    newTask.subtasks.push({ taskID: 4, taskName: "Allocate resources", startDate: new Date("02/03/2017"), endDate: new Date("02/07/2017"), duration: 5, progress: 100, priority: "Critical", approved: false } as Task);
    newTask.subtasks.push({ taskID: 5, taskName: "Planning complete", startDate: new Date("02/07/2017"), endDate: new Date("02/07/2017"), duration: 0, progress: 0, priority: "Low", approved: true } as Task);




    treeGridModel.push(newTask);


    newTask = new Task({ taskID: 6, taskName: "Design", startDate: new Date("02/10/2017"), endDate: new Date("02/14/2017"), duration: 3, progress: 86, priority: "High", approved: false } as Task);
    newTask.subtasks.push({ taskID: 7, taskName: "Software Specification", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: 60, priority: "Normal", approved: false } as Task);
    newTask.subtasks.push({ taskID: 8, taskName: "Develop prototype", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: 100, priority: "Critical", approved: false } as Task);
    newTask.subtasks.push({ taskID: 9, taskName: "Get approval from customer", startDate: new Date("02/13/2017"), endDate: new Date("02/14/2017"), duration: 2, progress: 100, approved: true } as Task);
    newTask.subtasks.push({ taskID: 10, taskName: "Design Documentation", startDate: new Date("02/13/2017"), endDate: new Date("02/14/2017"), duration: 2, progress: 100, approved: true } as Task);

    treeGridModel.push(newTask);
    return treeGridModel;
}


class Task {


    constructor(newTask: Task) {
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


    set taskName(value: string) {
        this._taskName = value;
    }

    get taskName(): string {
        return this._taskName;
    }

    protected _taskName: string;



    set taskID(value: number) {
        this._taskID = value;
    }

    get taskID(): number {
        return this._taskID;
    }

    protected _taskID: number;

    set startDate(value: Date) {
        this._startDate = value;
    }

    get startDate(): Date {
        return this._startDate;
    }

    protected _startDate: Date;

    set endDate(value: Date) {
        this._endDate = value;
    }

    get endDate(): Date {
        return this._endDate;
    }

    protected _endDate: Date;

    set duration(value: number) {
        this._duration = value;
    }

    get duration(): number {
        return this._duration;
    }

    protected _duration: number;

    set progress(value: number) {
        this._progress = value;
    }

    get progress(): number {
        return this._progress;
    }

    protected _progress: number;

    set priority(value: string) {
        this._priority = value;
    }

    get priority(): string {
        return this._priority;
    }


    protected _priority: string;

    set approved(value: boolean) {
        this._approved = value;
    }

    get approved(): boolean {
        return this._approved;
    }

    protected _approved: boolean;


    set subtasks(value: Task[]) {
        this._subtasks = value;
    }

    get subtasks(): Task[] {
        return this._subtasks;
    }

    private _subtasks: Task[] = [];

}
