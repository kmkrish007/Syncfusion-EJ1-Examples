window.GroupingList = ["GRIDS", "DATA VISUALIZATION", "LAYOUT", "EDITORS", "NAVIGATION", "NOTIFICATION", "FILE FORMATS", "REPORTING", "BUSINESS INTELLIGENCE", "DATA SCIENCE", "INTEGRATION"];
//Controls List
window.SampleControls = [{ "name": "Chart" }, { "name": "Pdf" }, { "name": "Presentation" }, { "name": "XlsIO" }, { "name": "DocIO" }, { "name": "BulletGraph" }, { "name": "RangeNavigator" },
   { "name": "Grid" }, { "name": "Ribbon" }, { "name": "RadialMenu" }, { "name": "Diagram" }, { "name": "Gantt" }, { "name": "TreeGrid" }, { "name": "Schedule" }, { "name": "RichTextEditor" }, { "name": "TreeView" }, { "name": "FileExplorer" }, { "name": "ColorPicker" }, { "name": "DatePicker" }, { "name": "TimePicker" }, { "name": "DateTimePicker" },
   { "name": "OlapClient" }, { "name": "PivotGrid" }, { "name": "OlapChart" }, { "name": "OlapGauge" },
   { "name": "Textboxes" }, { "name": "AutoComplete" }, { "name": "Rotator" }, { "name": "Tab" }, { "name": "Menu" }, { "name": "Barcode" }, { "name": "Accordion" },
   { "name": "ProgressBar" }, { "name": "Rating" }, { "name": "ReportViewer" }, /* { "name": "ReportWriter" }, */{ "name": "ListBox" }, { "name": "DropDownList" }, { "name": "Slider" }, { "name": "Splitter" },
   { "name": "TagCloud" }, { "name": "Buttons" }, { "name": "Toolbar" }, { "name": "WaitingPopup" }, { "name": "Dialog" }, { "name": "ListView" }, { "name": "TileView" }, { "name": "ScrollBar" }, { "name": "NavigationDrawer" }, { "name": "Maps" }, { "name": "TreeMap" }, { "name": "CircularGauge" }, { "name": "DigitalGauge" }, { "name": "LinearGauge" }, { "name": "Captcha", "type": "New" }, { "name": "UploadBox" }, { "name": "Analytics" }, { "name": "AngularSupport" }, { "name": "KOSupport" }

];
//Samples List
window.SamplesList = [

    {
        "name": "Chart",
        "id": "Chart",
        "type": "update",
        "childcount": "1",
        "action": "DefaultFunctionalities",
        "Group": "DATA VISUALIZATION",
        "samples": [
            { "id": "1", "name": "Line ", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Step Line ", "action": "StepLine", "childcount": "0" },
            { "id": "3", "name": "Area ", "action": "Area", "childcount": "0" },
            { "id": "4", "name": "Step Area ", "action": "StepArea", "childcount": "0" },
            { "id": "5", "name": "Spline Area ", "action": "SplineArea", "childcount": "0" },
            { "id": "6", "name": "Stacked Area ", "action": "StackingArea", "childcount": "0" },
            { "id": "7", "name": "100% Stacked Area ", "action": "StackingArea100", "childcount": "0" },
			{ "id": "8", "name": "Range Area ", "action": "RangeArea", "childcount": "0" },
            { "id": "9", "name": "Column ", "action": "Column", "childcount": "0" },
            { "id": "10", "name": "Range Column ", "action": "RangeColumn", "childcount": "0" },
            { "id": "11", "name": "Stacked Column ", "action": "StackingColumn", "childcount": "0" },
            { "id": "12", "name": "100% Stacked Column ", "action": "StackingColumn100", "childcount": "0" },
            { "id": "13", "name": "Bar ", "action": "Bar", "childcount": "0" },
            { "id": "14", "name": "Stacked Bar ", "action": "StackingBar", "childcount": "0" },
            { "id": "15", "name": "100% Stacked Bar ", "action": "StackingBar100", "childcount": "0" },
            { "id": "16", "name": "Spline ", "action": "Spline", "childcount": "0" },
            { "id": "17", "name": "Pie ", "action": "Pie", "childcount": "0" },
            { "id": "18", "name": "Doughnut ", "action": "doughnut", "childcount": "0" },
			{ "id": "19", "name": "Semi Pie and Doughnut", "controller": "", "action": "SemiPie", "childcount": "0" },
            { "id": "20", "name": "Pyramid ", "action": "Pyramid", "childcount": "0" },
            { "id": "21", "name": "Funnel ", "action": "Funnel", "childcount": "0" },
            { "id": "22", "name": "Bubble ", "action": "Bubble", "childcount": "0" },
            { "id": "23", "name": "Scatter ", "action": "Scatter", "childcount": "0" },
            { "id": "24", "name": "Candle ", "action": "Candle", "childcount": "0" },
            { "id": "25", "name": "Hilo ", "action": "Hilo", "childcount": "0" },
            { "id": "26", "name": "Hilo Open Close ", "action": "HiloOpenClose", "childcount": "0" },
			{ "id": "27", "name": "Polar ", "action": "Polar", "childcount": "0" },
             { "id": "28", "name": "Radar ", "action": "Radar", "childcount": "0" },
             { "id": "29", "name": "Wind Rose", "action": "Windrose", "childcount": "0" },
              { "id": "30", "name": "Waterfall", "action": "waterfall", "childcount": "0", "type": "new" },
             { "id": "31", "name": "Combination ", "action": "Combination", "childcount": "0" },
			 { "id": "32", "name": "Vertical Chart", "action": "VerticalChart", "childcount": "0" },
             { "id": "33", "name": "Trendlines", "action": "Trendlines", "childcount": "0", type: "update" },
			 { "id": "34", "name": "Error Bar", "action": "ErrorBar", "childcount": "0", "type": "new" },
             { "id": "35", "name": "Live ", "action": "Live", "childcount": "0" },
             { "id": "36", "name": "Performance", "action": "LoadPoints", "childcount": "0" },
             { "id": "37", "name": "Export", "action": "Export", "childcount": "0" },
             {
                 "id": "38", "name": "Technical Indicators", "action": "Rsi", "childcount": "1", samples: [
                 //second hierarchy
                        { "id": "311", "name": "RSI", "action": "Rsi", "childcount": "0" },
                        { "id": "312", "name": "Momentum", "action": "Momentum", "childcount": "0" },
                         { "id": "313", "name": "BollingerBand", "action": "Bollingerband", "childcount": "0" },
                          { "id": "314", "name": "AccumulationDistribution", "action": "Accumulationdistribution", "childcount": "0" },
						  { "id": "315", "name": "SMA", "action": "Sma", "childcount": "0" },
                          { "id": "316", "name": "EMA", "action": "Ema", "childcount": "0" },
						  { "id": "317", "name": "Stochastic", "action": "Stochastic", "childcount": "0" },
                          { "id": "318", "name": "ATR", "action": "ATR", "childcount": "0" },
                          { "id": "319", "name": "MACD", "action": "Macd", "childcount": "0" },
						  { "id": "320", "name": "TMA", "action": "Tma", "childcount": "0" }

                 ]
             },
      {
          "id": "39", "name": "3D ", "action": "Column3D", "childcount": "1", samples: [
               //second hierarchy
                { "id": "321", "name": "Column", "action": "Column3D", "childcount": "0" },
                { "id": "322", "name": "Bar", "action": "Bar3D", "childcount": "0" },
                { "id": "323", "name": "Stacked Column", "action": "StackingColumn3D", "childcount": "0" },
                { "id": "324", "name": "100% Stacked Column", "action": "StackingColumn1003D", "childcount": "0" },
                { "id": "325", "name": "Stacked Bar", "action": "StackingBar3D", "childcount": "0" },
                { "id": "326", "name": "100% Stacked Bar", "action": "StackingBar1003D", "childcount": "0" },
                { "id": "327", "name": "Pie", "action": "Pie3D", "childcount": "0" },
                { "id": "328", "name": "Doughnut", "action": "Doughnut3D", "childcount": "0" }]
      },
            {
                "id": "40", "name": "Chart Axes", "action": "MultipleAxes", "childcount": "1", samples: [
                     //second hierarchy
                      { "id": "331", "name": "Multiple Axes", "action": "MultipleAxes", "childcount": "0" },
					  { "id": "332", "name": "Trim Title", "action": "Trim", "childcount": "0" },
                      { "id": "333", "name": "Stripline", "action": "StriplineSample", "childcount": "0" },
                      { "id": "334", "name": "DateTime Axis", "action": "DateTimeAxis", "childcount": "0" },
                      { "id": "335", "name": "Log Axis", "action": "LogAxis", "childcount": "0" },
					  { "id": "336", "name": "Smart Axis Labels", "action": "SmartAxisLabel", "childcount": "0", "type": "update" },
                      { "id": "337", "name": "Felxible Axis Layout", "action": "FlexibleAxis", "childcount": "0" },
                      { "id": "338", "name": "Inversed Axis", "action": "InversedAxis", "childcount": "0" },
                { "id": "339", "name": "Alternate Grid Band", "action": "AlternateGridBand", "childcount": "0" }]
            },
            {
                "id": "41", "name": "Chart Customization", "action": "Symbols", "childcount": "1", samples: [
                //second hierarchy
                       { "id": "341", "name": "Symbols", "action": "Symbols", "childcount": "0" },
                       { "id": "342", "name": "Empty Points", "action": "EmptyPoints", "childcount": "0", "type": "update" },
                       { "id": "343", "name": "Tooltip Template", "action": "TooltipTemplate", "childcount": "0" },
                       { "id": "344", "name": "Label Template", "action": "LabelTemplate", "childcount": "0" },
                       { "id": "345", "name": "Smart Labels", "action": "SmartLabels", "childcount": "0" },
					   { "id": "346", "name": "Annotations", "action": "Annotations", "childcount": "0" },
                       { "id": "347", "name": "Legend Position", "action": "LegendPosition1", "childcount": "0", "type": "update" },
                       { "id": "348", "name": "Localization", "action": "Localization", "childcount": "0" },
                       { "id": "349", "name": "SubTitle", "action": "SubTitle", "childcount": "0" },
                       { "id": "350", "name": "Selection", "action": "Selection", "childcount": "0", "type": "update" }]
            },
            {
                "id": "42", "name": "Data Binding", "action": "LocalBinding", "childcount": "1", samples: [
                //second hierarchy
                      { "id": "351", "name": "Local Binding", "action": "LocalBinding", "childcount": "0" },
                      { "id": "352", "name": "Remote Binding", "action": "RemoteBinding", "childcount": "0" },
                      { "id": "355", "name": "Access Binding", "action": "AccessDataBinding", "childcount": "0" },
                      { "id": "356", "name": "Object Binding", "action": "ObjectBinding", "childcount": "0" },
                      { "id": "357", "name": "SQL Binding", "action": "SQLBinding", "childcount": "0" },
                      { "id": "358", "name": "XML Binding", "action": "XmlBinding", "childcount": "0" }
                ]
            },
            {
                "id": "43", "name": "User Interaction", "action": "Zooming", "childcount": "1", samples: [
                //second hierarchy
                       { "id": "361", "name": "Zooming and Panning", "action": "Zooming", "childcount": "0" },
                       { "id": "362", "name": "Crosshair", "action": "Crosshair", "childcount": "0" },
                       { "id": "363", "name": "Trackball", "action": "Trackball", "childcount": "0","type":"update" },
                       { "id": "364", "name": "Events", "action": "Events", "childcount": "0", "type": "update" },
                       { "id": "365", "name": "Drill Down", "action": "Drilldown", "childcount": "0" }]
            }
        ]
    },



    {
        "name": "Grid",
        "id": "Grid",
        "childcount": "1",
        "Group": "GRIDS",
        "action": "DefaultFunctionalities",
        "type": "update",
        "samples": [
            {
                "id": "1", "name": "Default", "action": "DefaultFunctionalities", "childcount": "0"
            },
            {
                "id": "2", "name": "Data Binding", "action": "LocalBinding", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "List Binding", "action": "LocalBinding", "childcount": "0" },
                    { "id": "2", "name": "Remote Data", "action": "UrlBinding", "childcount": "0" },
                    { "id": "8", "name": "OData Binding", "action": "ODataBinding", "type": "new", "childcount": "0", "isResponsive": "false" },
                    { "id": "3", "name": "Table", "action": "TableBinding", "childcount": "0" },
                    { "id": "4", "name": "Load At Once", "action": "LoadAtOnce", "childcount": "0" },
                    { "id": "5", "name": "Object Data", "action": "ObjectBinding", "childcount": "0" },
                    { "id": "6", "name": "SQL Data", "action": "SQLBinding", "childcount": "0" },
                    { "id": "7", "name": "XML Data", "action": "XMLBinding", "childcount": "0" },
                    { "id": "31", "name": "Data Caching", "controller": "Grid", "action": "DataCaching", "childcount": "0" },
                    { "id": "14", "name": "Real Time Binding", "action": "RealTimeBinding", "childcount": "0" },
                    { "id": "15", "name": "Live Update", "action": "LiveUpdate", "type": "update", "childcount": "0" }
                ]
            },
            {
                "id": "3", "name": "Columns", "action": "ColumnFormatting", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Column Formatting", "action": "ColumnFormatting", "childcount": "0" },
                    { "id": "2", "name": "Cell Alignment", "action": "CellAlignment", "childcount": "0" },
                    { "id": "3", "name": "Reorder", "action": "Reorder", "childcount": "0" },
                    { "id": "4", "name": "Resize", "action": "Resizing", "childcount": "0", "isResponsive": "false" },
                    { "id": "5", "name": "Resize To Fit", "action": "ResizetoFit", "childcount": "0", "isResponsive": "false" },
                    { "id": "6", "name": "Custom Command", "action": "CustomCommand", "childcount": "0" },
                    { "id": "7", "name": "Column Template", "action": "ColumnTemplate", "childcount": "0" },
                    { "id": "8", "name": "Header Template", "action": "HeaderTemplate", "childcount": "0" },
                    { "id": "9", "name": "Show or Hide Column", "action": "ShowHideColumn", "childcount": "0" },
                    { "id": "10", "name": "Foreign Key Column", "action": "ForeignKeyColumn", "childcount": "0" },
                    { "id": "11", "name": "Frozen Rows and Columns", "action": "FrozenRowsandColumns", "childcount": "0", "isResponsive": "false" },
					{ "id": "13", "name": "AutoWrap Column Cells", "action": "AutoWrap", "childcount": "0" },
					{ "id": "14", "name": "Cell Merging", "action": "CellMerging", "childcount": "0" },
                    { "id": "16", "name": "Column Chooser", "controller": "Grid", "action": "ColumnChooser", "type": "update", "childcount": "0" },
                    { "id": "17", "name": "Stacked Header", "controller": "Grid", "action": "StackedHeader", "childcount": "0" }
                ]
            },
            {
                "id": "4", "name": "Rows", "action": "RowTemplate", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Row Template", "action": "RowTemplate", "childcount": "0" },
                    { "id": "2", "name": "Detail Template", "action": "DetailTemplate", "childcount": "0" },
                    { "id": "3", "name": "Row Hover", "action": "RowHover", "childcount": "0" }
                ]
            },
            {
                "id": "5", "name": "Editing", "action": "InlineOnLocalData", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Inline Editing ", "action": "InlineOnLocalData", "childcount": "0" },
                    { "id": "2", "name": "Dialog Editing", "action": "DialogOnLocalData", "childcount": "0" },
                    { "id": "3", "name": "Inline Form Editing", "action": "InlineFormOnLocalData", "childcount": "0", "isResponsive": "false" },
                    { "id": "4", "name": "External Form Editing", "action": "ExternalFormOnLocalData", "childcount": "0", "isResponsive": "false" },
                    { "id": "5", "name": "Cell Edit Type", "action": "CellEditType", "childcount": "0" },
                    { "id": "6", "name": "Batch Editing", "action": "BatchEditing", "childcount": "0", "isResponsive": "false" },
                    { "id": "7", "name": "Lock Row", "action": "LockRow", "childcount": "0" },
                    { "id": "8", "name": "Command Column", "action": "CommandColumn", "childcount": "0" },
                    { "id": "9", "name": "Edit Template", "action": "EditTemplate", "childcount": "0" }

                ]
            },
            {
                "id": "6", "name": "Sorting", "action": "MultiSorting", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Multi Sorting", "action": "MultiSorting", "childcount": "0" },
                    { "id": "2", "name": "Sorting API", "action": "SortingAPI", "childcount": "0" }
                ]
            },
            {
                "id": "7", "name": "Filtering", "action": "DefaultFiltering", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Default Functionalities", "action": "DefaultFiltering", "childcount": "0" },
                    { "id": "2", "name": "Filtering Menu", "action": "FilteringMenu", "childcount": "0" },
                    { "id": "3", "name": "Searching", "action": "Searching", "childcount": "0" }
                ]
            },
            {
                "id": "8", "name": "Grouping", "action": "Grouping", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Default Functionalities", "action": "Grouping", "childcount": "0" },
                    { "id": "2", "name": "Group Button", "action": "GroupButton", "childcount": "0", "isResponsive": "false" },
                    { "id": "3", "name": "Hide Grouped Columns", "action": "HideGroupedColumn", "childcount": "0", "isResponsive": "false" },
                    { "id": "4", "name": "Grouping API", "action": "GroupingAPI", "childcount": "0", "isResponsive": "false" }
                ]
            },
            {
                "id": "9", "name": "Paging", "action": "DefaultPaging", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Default Functionalities", "action": "DefaultPaging", "childcount": "0" },
                    { "id": "2", "name": "Paging API", "action": "PagingAPI", "childcount": "0" },
                    { "id": "3", "name": "Virtual Paging", "action": "VirtualPaging", "childcount": "0" },
                    { "id": "4", "name": "Pager Templates", "controller": "Grid", "action": "PagerImprovements", "childcount": "0" }

                ]
            },
            {
                "id": "10", "name": "Selection", "action": "BasicSelection", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Basic", "action": "BasicSelection", "childcount": "0" },
                    { "id": "2", "name": "Refresh Selection Cleanup", "action": "RefreshSelectionCleanup", "childcount": "0" }
                ]
            },
            {
                "id": "11", "name": "Summary", "action": "Summary", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Basic", "action": "Summary", "childcount": "0" },
                    { "id": "2", "name": "Group Summary", "action": "GroupSummary", "childcount": "0", "isResponsive": "false" },
                    { "id": "3", "name": "Caption Summary", "action": "CaptionSummary", "childcount": "0", "isResponsive": "false" },
                    { "id": "4", "name": "Custom Summary", "action": "CustomSummary", "childcount": "0" }
                ]
            },
            {
                "id": "13", "name": "Server Side Events", "action": "DefaultServerEvents", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Default Server Events", "action": "DefaultServerEvents", "childcount": "0" },
                    { "id": "2", "name": "Edit Events", "action": "ServerEditEvents", "childcount": "0" }
                ]
            },
             {
                 "id": "25", "name": "Export and Print", "controller": "Grid", "action": "ExcelExporting", "childcount": "1", "samples": [
                           { "id": "1", "name": "Exporting Grid", "controller": "Grid", "action": "ExcelExporting", "childcount": "0" },
                           { "id": "2", "name": "Multiple Exporting", "controller": "Grid", "action": "MultipleExporting", "childcount": "0" },
                           { "id": "3", "name": "Print Grid", "controller": "Grid", "action": "PrintGrid", "childcount": "0" }
                 ]
             },

            { "id": "29", "name": "Adaptive Grid", "action": "AdaptiveGrid", "childcount": "0", "isResponsive": "false" },
			{ "id": "36", "name": "GridLines", "action": "GridLines", "childcount": "0" },
            { "id": "16", "name": "Conditional Formatting", "action": "ConditionalFormatting", "isResponsive": "false", "childcount": "0" },
            { "id": "17", "name": "Master-Details", "action": "MasterDetails", "childcount": "0" },
            { "id": "18", "name": "State Maintenance", "action": "StateMaintenance", "childcount": "0" },
            { "id": "19", "name": "ToolBar Template", "action": "Toolbartemplate", "childcount": "0" },
            { "id": "20", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" },
            { "id": "21", "name": "Scrolling", "action": "Scrolling", "childcount": "0" },
            { "id": "22", "name": "Events", "action": "Events", "childcount": "0" },
            { "id": "35", "name": "Context Menu", "action": "ContextMenu", "childcount": "0" },
            {
                "id": "23", "name": "Internationalization", "controller": "Grid", "action": "ExcelExporting", "childcount": "1", "samples": [
                         { "id": "1", "name": "Localization", "action": "Localization", "childcount": "0" },
                         { "id": "2", "name": "RTL", "action": "RTL", "childcount": "0" }
                ]
            }
        ]
    },
	{
	    "name": "Gantt", "id": "Gantt", "Group": "DATA VISUALIZATION", "childcount": "1", "action": "Default", "isResponsive": "false", "type": "update", "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },

              {
                  "id": "2", "name": "Data Binding", "action": "ObjectBinding", "childcount": "1",
                  "samples": [
                      { "id": "1", "name": "Object Data", "action": "ObjectBinding", "childcount": "0" },
                      { "id": "2", "name": "XML Data", "action": "XMLBinding", "childcount": "0" },
                      { "id": "3", "name": "SQL Data", "action": "SQLDataBinding", "childcount": "0" },
                      { "id": "4", "name": "Self Reference", "action": "SelfReference", "childcount": "0", "type": "new" },
                      { "id": "5", "name": "Performance", "action": "Virtualization", "childcount": "0" }
                  ]
              },
             { "id": "3", "name": "Schedule Modes", "action": "ScheduleModes", "childcount": "0", "type": "update" },
             { "id": "4", "name": "Time Options", "action": "TimeOption", "childcount": "0" },
             {
                 "id": "5", "name": "Columns", "action": "ColumnChooser", "childcount": "1",
                 "samples": [
                     { "id": "1", "name": "Column Chooser", "action": "ColumnChooser", "childcount": "0" },
                     { "id": "2", "name": "Column Template", "action": "ColumnTemplate", "childcount": "0", "type": "new" }
                 ]
             },
             {
                 "id": "6", "name": "Context Menu", "action": "DefaultContextMenu", "childcount": "1",
                 "samples": [
                     { "id": "1", "name": "Default Functionalities", "action": "DefaultContextMenu", "childcount": "0" },
                     { "id": "2", "name": "Custom Context Menu", "action": "GanttContextMenu", "childcount": "0", "type": "new" }
                 ]
             },
             {
                 "id": "7", "name": "Sorting", "action": "Sorting", "childcount": "1",
                 "samples": [
                     { "id": "1", "name": "Default Functionalities", "action": "Sorting", "childcount": "0" },
                     { "id": "2", "name": "Sorting API", "action": "CustomSorting", "childcount": "0", "type": "new" }
                 ]
             },
            { "id": "8", "name": "Editing", "action": "Editing", "childcount": "0" },
            { "id": "9", "name": "Events", "action": "Events", "childcount": "0", "type": "update" },
            { "id": "10", "name": "Localization", "action": "Localization", "childcount": "0" },
            { "id": "11", "name": "BaseLines", "action": "BaseLine", "childcount": "0" },
            { "id": "12", "name": "Resource", "action": "Resource", "childcount": "0" },
            { "id": "13", "name": "Searching", "action": "Searching", "childcount": "0" },
            { "id": "14", "name": "Striplines", "action": "Stripline", "childcount": "0", "type": "new" },
            { "id": "15", "name": "Timescale Extension", "action": "TimelineValidation", "childcount": "0" },
            { "id": "16", "name": "Tooltip Template", "action": "TooltipTemplate", "childcount": "0", "type": "new" },
            { "id": "17", "name": "Keyboard Interaction", "action": "KeyboardNavigation", "childcount": "0", "type": "new" }
	    ]
	},

    {
        "name": "TreeGrid", "id": "TreeGrid", "childcount": "1", "Group": "GRIDS", "action": "TreeGridDefault", "type": "update", "isResponsive": "false", "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "TreeGridDefault", "childcount": "0" },
            {
                "id": "2", "name": "Data Binding", "action": "ObjectBinding", "childcount": "1",
                "samples": [
                    { "id": "1", "name": "Object Data", "action": "ObjectBinding", "childcount": "0" },
                    { "id": "2", "name": "XML Data", "action": "XMLBinding", "childcount": "0" },
                    { "id": "3", "name": "SQL Data", "action": "SQLBinding", "childcount": "0" },
                    { "id": "4", "name": "Local Binding", "action": "LocalBinding", "childcount": "0" },
                    { "id": "5", "name": "Self Reference", "action": "SelfReference", "childcount": "0", "type": "new" },
                    { "id": "6", "name": "Performance", "action": "Virtualization", "childcount": "0", "type": "new" }
                ]
            },
            {
                "id": "3", "name": "Columns", "action": "ColumnTemplate", "childcount": "1",
                "samples": [
                     { "id": "1", "name": "Column Template", "action": "ColumnTemplate", "childcount": "0" },
                     { "id": "2", "name": "Column Chooser", "action": "TreeGridColumnChooser", "childcount": "0" },
                     { "id": "3", "name": "Header Template", "action": "TreeGridHeaderTemplate", "childcount": "0", "type": "new" },
                     { "id": "17", "name": "Frozen Columns", "action": "TreeGridFrozenColumns", "childcount": "0", "type": "new" }
                ]
            },
            {
                "id": "4", "name": "Rows", "action": "TreeGridRowTemplate", "childcount": "1",
                "samples": [
                     { "id": "1", "name": "Row Template", "action": "TreeGridRowTemplate", "childcount": "0" },
                     { "id": "2", "name": "Row Drag And Drop", "action": "TreeGridRowDragAndDrop", "childcount": "0" },
                     { "id": "3", "name": "Details Template", "action": "TreeGridRowDetails", "childcount": "0" },
                     { "id": "4", "name": "Summary Row", "action": "TreeGridSummaryRow", "childcount": "0" }
                ]
            },
            { "id": "5", "name": "Editing", "action": "TreeGridEditing", "childcount": "0" },
            { "id": "6", "name": "Sorting", "action": "TreeGridSorting", "childcount": "0" },
            { "id": "7", "name": "Column Filtering", "action": "TreeGridColumnFiltering", "childcount": "0" },
            {
                "id": "8", "name": "Export", "action": "TreeGridExporting", "childcount": "1",
                "samples": [
                     { "id": "1", "name": "Exporting TreeGrid", "action": "TreeGridExporting", "childcount": "0" },
                     { "id": "2", "name": "Multiple Exporting", "action": "TreeGridMultipleExporting", "childcount": "0" }
                ]
            },
            { "id": "9", "name": "Events", "action": "Events", "childcount": "0" },
            {
                "id": "10", "name": "Context Menu", "action": "TreeGridContextMenu", "childcount": "1",
                "samples": [
                     { "id": "1", "name": "Default Functionalities", "action": "TreeGridContextMenu", "childcount": "0" },
                     { "id": "2", "name": "Custom Context Menu", "action": "TreeGridCustomContextMenu", "childcount": "0", "type": "new" }
                ]
            },
            {
                "id": "11", "name": "AngularJS Templates", "action": "TreeGridAngularRowTemplate", "childcount": "1",
                "samples": [
                     { "id": "1", "name": "Row Template", "action": "TreeGridAngularRowTemplate", "childcount": "0" },
                     { "id": "2", "name": "Column Template", "action": "TreeGridAngularColumnTemplate", "childcount": "0" }
                ]
            },
            { "id": "12", "name": "Keyboard Navigation", "action": "KeyboardNavigation", "childcount": "0", "type": "new" }
        ]
    },
    {
        "name": "Schedule", "id": "Schedule", "childcount": "1", "action": "Default", "Group": "DATA VISUALIZATION", "type": "update", "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
             {
                 "id": "2", "name": "Data Binding", "action": "SQLData", "childcount": "1",
                 "samples": [
                       { "id": "1", "name": "SQL Data Binding", "action": "SQLData", "childcount": "0" },
                       { "id": "2", "name": "XML Binding", "action": "xmlbinding", "childcount": "0" },
                       { "id": "3", "name": "Object Data Binding", "action": "objectdata", "childcount": "0" },
                       { "id": "4", "name": "Remote Data Binding", "action": "RemoteDataBinding", "childcount": "0" },
                       { "id": "5", "name": "Load On Demand", "action": "LoadOnDemand", "childcount": "0" }
                 ]
             },
             { "id": "3", "name": "Timeline View", "action": "HorizontalDefault", "childcount": "0" },
             {
                 "id": "4", "name": "Multiple Resources", "action": "HorizontalMultipleResource", "childcount": "1",
                 "samples": [
                       { "id": "1", "name": "Timeline View", "action": "HorizontalMultipleResource", "childcount": "0", "isResponsive": "false" },
                       { "id": "2", "name": "Vertical View", "action": "multipleresource", "childcount": "0" }
                 ]
             },
             {
                 "id": "5", "name": "Resource Grouping", "action": "HorizontalResourceGrouping", "childcount": "1",
                 "samples": [
                       { "id": "1", "name": "Timeline View", "action": "HorizontalResourceGrouping", "childcount": "0", "isResponsive": "false" },
                       { "id": "2", "name": "Vertical View", "action": "ResourceGrouping", "childcount": "0" }
                 ]
             },
             { "id": "6", "name": "TimeScale", "action": "TimeScale", "childcount": "0", "type": "new" },
             { "id": "7", "name": "Adaptive", "action": "AdaptiveSchedule", "childcount": "0", "isResponsive": "false" },
             {
                 "id": "8", "name": "Export & Print", "action": "PDFExport", "childcount": "1",
                 "samples": [
                       { "id": "1", "name": "PDF Export", "action": "PDFExport", "childcount": "0", "isResponsive": "false", "type": "new" },
                       { "id": "2", "name": "ICS Export & Import", "action": "ScheduleICSExport", "childcount": "0", "isResponsive": "false" },
                       { "id": "3", "name": "Print", "action": "Print", "childcount": "0", "isResponsive": "false" }
                 ]
             },
             { "id": "9", "name": "Cell Auto Fit", "action": "CellAutoFit", "childcount": "0", "type": "new" },
             { "id": "10", "name": "External Drag and Drop", "action": "ExternalDragAndDrop", "childcount": "0", "type": "new" },
             {
                 "id": "11", "name": "Template", "action": "templates", "childcount": "1",
                 "samples": [
                       { "id": "1", "name": "Appointment", "action": "templates", "childcount": "0" },
                       { "id": "2", "name": "Cell", "action": "Celltemplate", "childcount": "0", "type": "new" }
                 ]
             },
             { "id": "12", "name": "Localization", "action": "localization", "childcount": "0" },
             { "id": "13", "name": "Validation", "action": "Validation", "childcount": "0", "type": "new" },
             { "id": "14", "name": "Appointment Categorize", "action": "CategorizeOption", "childcount": "0" },
             { "id": "15", "name": "Custom Window", "action": "CustomWindow", "childcount": "0", "isResponsive": "false" },
             { "id": "16", "name": "Custom View", "action": "CustomView", "childcount": "0" },
             { "id": "17", "name": "Context Menu", "action": "ContextMenu", "childcount": "0", "isResponsive": "false" },
             { "id": "18", "name": "Appointment Tooltip", "action": "Tooltip", "childcount": "0", "isResponsive": "false" },
             { "id": "19", "name": "Time Mode", "action": "TimeMode", "childcount": "0" },
             { "id": "20", "name": "FirstDayOfWeek", "action": "FirstDayOfWeek", "childcount": "0" },
             { "id": "21", "name": "SignalR", "action": "SignalR", "childcount": "0" },
             { "id": "22", "name": "RTL", "action": "RTL", "childcount": "0" },
             { "id": "23", "name": "Appointment Search", "action": "AppointmentSearch", "childcount": "0", "isResponsive": "false" },
             { "id": "24", "name": "Reminder", "action": "Reminder", "childcount": "0", "isResponsive": "false" },
             { "id": "25", "name": "KeyBoard Interaction", "action": "KeyBoardNavigation", "childcount": "0", "isResponsive": "false" },
             { "id": "26", "name": "API's", "action": "API", "childcount": "0" },
             { "id": "27", "name": "Events", "action": "Events", "childcount": "0" }
        ]
    },

    {
        "name": "Diagram",
        "id": "Diagram",
        "childcount": "1",
        "action": "FlowDiagram",
        "type": "update",
        "isResponsive": "false",
        "Group": "DATA VISUALIZATION",
        "samples": [
                    { "id": "1", "name": "Default Functionalities", "action": "FlowDiagram", "childcount": "0", "type": "" },
                    {
                        "id": "2", "name": "Getting Started", "querystring": "diagram", "childcount": "1", "type": "",
                        "samples": [
                                { "id": "1", "name": "Shapes Gallery", "action": "DiagramShapes", "childcount": "0", "type": "new" },
                                { "id": "2", "name": "Connectors", "action": "Connectors", "childcount": "0", "type": "new" },
                                { "id": "3", "name": "Swimlane", "action": "Swimlane", "childcount": "0", "type": "" },
			                    { "id": "4", "name": "DrawingTools", "action": "DrawingTools", "childcount": "0", "type": "" },
                                { "id": "5", "name": "Overview", "action": "Overview", "childcount": "0", "type": "" },
                                { "id": "6", "name": "Localization", "action": "Localization", "childcount": "0", "type": "" },
                                { "id": "7", "name": "Tooltip", "action": "TooltipDiagram", "childcount": "0", "type": "new" }
                        ]
                    },
                    {
                        "id": "3", "name": "Automatic Layout", "querystring": "diagram", "childcount": "1", "type": "",
                        "samples": [
                             { "id": "1", "name": "HierarchicalLayout", "action": "HierarchicalLayout", "childcount": "0", "type": "new" },
                             { "id": "2", "name": "Organizational Chart", "action": "ProjectManagementOrgChart", "childcount": "0", "type": "update" },
                             { "id": "3", "name": "Radial Tree", "action": "RadialTree", "childcount": "0", "type": "" }
                        ]
                    },
                    {
                        "id": "4", "name": "Organizational Chart", "querystring": "diagram", "childcount": "1", "type": "",
                        "samples": [
                             { "id": "1", "name": "Team", "action": "TeamOrgChart", "childcount": "0", "type": "" },
                             { "id": "2", "name": "Business Management", "action": "BusinessOrgChart", "childcount": "0", "type": "" },
                             { "id": "3", "name": "University", "action": "UniversityOrgChart", "childcount": "0", "type": "" }
                        ]
                    },
                    {
                        "id": "5", "name": "Usecase Diagrams", "querystring": "diagram", "childcount": "1", "type": "",
                        "samples": [
                            { "id": "1", "name": "Mindmap", "action": "MindMap", "childcount": "0", "type": "" },
                            { "id": "2", "name": "UML Diagram", "action": "UML", "childcount": "0", "type": "" },
                            { "id": "3", "name": "Circuit Diagram", "action": "CircuitDiagram", "childcount": "0", "type": "" }
                        ]
                    },
                    {
                        "id": "6", "name": "Data Binding", "querystring": "diagram", "childcount": "1", "type": "",
                        "samples": [
                            { "id": "1", "name": "SQL Binding", "action": "SQLBinding", "childcount": "0", "type": "" },
                            { "id": "2", "name": "Local DataBinding", "action": "LocalDataBinding", "childcount": "0", "type": "" },
                            { "id": "3", "name": "Remote DataBinding", "action": "RemoteDataBinding", "childcount": "0", "type": "" },
                            { "id": "4", "name": "HTML DataBinding", "action": "HTMLDataBinding", "childcount": "0", "type": "" }
                        ]
                    }
        ]
    },

	 {
	     "name": "Maps", "id": "Maps", "Group": "DATA VISUALIZATION", "childcount": "1", "controller": "Maps", "action": "DataMarkers", "samples": [
             { "id": "1", "name": "DataMarkers", "action": "DataMarkers", "childcount": "0" },
             { "id": "2", "name": "DrillDown", "action": "DrillDown", "childcount": "0" },
             { "id": "3", "name": "Labels", "action": "Labels", "childcount": "0" },
             { "id": "4", "name": "Selection", "action": "Selection", "childcount": "0" },
             { "id": "5", "name": "Zooming", "action": "Zooming", "childcount": "0" },
             { "id": "6", "name": "HeatMap", "action": "HeatMap", "childcount": "0" },
             { "id": "7", "name": "FlightRoutes", "action": "FlightRoutes", "childcount": "0" }
	     ]
	 },

     {
         "name": "TreeMap",
         "id": "TreeMap",
         "childcount": "1",
         "action": "Customization",
         "Group": "DATA VISUALIZATION",
         "samples": [
             { "id": "1", "name": "Customization", "action": "Customization", "childcount": "0" },
             { "id": "2", "name": "FlatCollection", "action": "FlatCollection", "childcount": "0" },
             { "id": "3", "name": "Hierarchical", "action": "Hierarchical", "childcount": "0" },
			 { "id": "4", "name": "DrillDown", "action": "drillDown", "childcount": "0" }
         ]
     },

      {
          "name": "CircularGauge", "id": "CircularGauge", "isResponsive": "false", "Group": "DATA VISUALIZATION", "childcount": "1", "action": "Default", "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "Scales", "action": "Scales", "childcount": "0" },
            { "id": "3", "name": "Ranges", "action": "Ranges", "childcount": "0" },
            {
                "id": "4", "name": "Pointers", "action": "Pointers", "childcount": "1", "samples": [
                 { "id": "1", "name": "Needle Pointer", "action": "Pointers", "childcount": "0" },
                 { "id": "2", "name": "Marker Pointer", "action": "MarkerPointer", "childcount": "0" },
                 { "id": "3", "name": "Image Pointer", "action": "PointerImage", "childcount": "0" }
                ]
            },
            { "id": "9", "name": "UserInteraction", "action": "UserInteraction", "childcount": "0" },
            { "id": "10", "name": "Export Image", "action": "ExportImage", "childcount": "0" },
            { "id": "11", "name": "Label Customization", "action": "LabelCustomization", "childcount": "0" },
            { "id": "12", "name": "Custom Label", "action": "Customlabel", "childcount": "0" },
            { "id": "13", "name": "Tooltip", "action": "Tooltip", "childcount": "0", },
            { "id": "14", "name": "Half Circular", "action": "Semicircular", "childcount": "0" },
            { "id": "16", "name": "Frames and Angles", "action": "Frames", "childcount": "0" },
            {
                "id": "17", "name": "Use Case", "action": "Clock", "childcount": "1", "samples": [
                   { "id": "1", "name": "Clock", "action": "Clock", "childcount": "0" },
                   { "id": "2", "name": "Speedometer", "action": "Speedometer", "childcount": "0" }
                ]
            }
          ]
      },

     {
         "name": "LinearGauge", "id": "LinearGauge", "isResponsive": "false", "childcount": "1", "Group": "DATA VISUALIZATION", "action": "Default", "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
           { "id": "2", "name": "Scales", "action": "Scales", "childcount": "0" },
           { "id": "3", "name": "Pointers", "action": "Pointers", "childcount": "0" },
           { "id": "4", "name": "Ranges", "action": "Ranges", "childcount": "0" },
           { "id": "5", "name": "Thermometer", "action": "Thermometer", "childcount": "0" },
           { "id": "8", "name": "UserInteraction", "action": "UserInteraction", "childcount": "0" },
           { "id": "9", "name": "Export Image", "action": "ExportImage", "childcount": "0" },
           { "id": "10", "name": "Label Customization", "action": "LabelCustomization", "childcount": "0" },
           { "id": "11", "name": "Tooltip", "action": "Tooltip", "childcount": "0" },
           { "id": "12", "name": "CustomLabel", "action": "CustomLabel", "childcount": "0" },
           { "id": "13", "name": "Indicators", "action": "Indicators", "childcount": "0" }


         ]
     },

      {
          "name": "DigitalGauge", "id": "DigitalGauge", "childcount": "1", "isResponsive": "false", "action": "Default", "Group": "DATA VISUALIZATION", "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
            { "id": "2", "name": "DigitalClock", "action": "DigitalClock", "childcount": "0" },
            { "id": "5", "name": "Export Image", "action": "ExportImage", "childcount": "0" }
          ]
      },
      {
          "name": "BulletGraph",
          "id": "BulletGraph",
          "childcount": "1",
          "action": "Default",
          "Group": "DATA VISUALIZATION",
          "samples": [
              { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
              { "id": "2", "name": "Data Binding - Local", "action": "LocalBinding", "childcount": "0" },
              { "id": "3", "name": "Data Binding - Remote", "action": "RemoteBinding", "childcount": "0" },
              { "id": "4", "name": "API's", "action": "API", "childcount": "0" },
              { "id": "7", "name": "Indicator", "action": "Indicator", "childcount": "0" },
              { "id": "8", "name": "Label & Tick Positioning", "action": "LabelsAndTicksPositioning", "childcount": "0" },
			  { "id": "9", "name": "Title Positioning", "action": "TitlePositioning", "childcount": "0" }
          ]
      },
     {
         "name": "RangeNavigator",
         "id": "RangeNavigator",
         "childcount": "1",
         "action": "Default",
         "Group": "DATA VISUALIZATION",
         "isResponsive": "false",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
             { "id": "2", "name": "Localization", "action": "RangeLocalization", "childcount": "0" },
             { "id": "3", "name": "RTL", "action": "RangeRTL", "childcount": "0" },
             { "id": "4", "name": "NumericType", "action": "NumericType", "childcount": "0" },
             { "id": "5", "name": "Customization", "action": "RangeCustom", "childcount": "0" }


         ]
     },
     {
         "name": "Ribbon",
         "id": "Ribbon",
         "childcount": "1",
         "Group": "NAVIGATION",
         "action": "DefaultFunctionalities",
         "isResponsive": "false",
         "type": "update",
         "samples": [
             { "id": "1", "name": "Default", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "API's", "action": "API", "childcount": "0" },
             { "id": "3", "name": "Events", "action": "Events", "childcount": "0" },
             { "id": "4", "name": "ServerSideEvents", "action": "ServerSideEvents", "childcount": "0" },
             { "id": "5", "name": "Resize", "action": "Resize", "childcount": "0" },
             { "id": "6", "name": "Gallery", "action": "Gallery", "childcount": "0" },
             { "id": "7", "name": "CustomToolTip", "action": "CustomToolTip", "childcount": "0" },
             { "id": "8", "name": "Backstage Page", "action": "BackStage", "childcount": "0" },
			 { "id": "9", "name": "Quick Access Toolbar", "action": "QuickAccess", "childcount": "0", "type": "new" }
         ]
     },
	      // {
         // "name": "ReportWriter",
         // "id": "ReportWriter",
         // "childcount": "1",
         // "type": "",
         // "action": "DefaultFunctionalities",
         // "samples": [
             // { "id": "1", "name": "Default", "action": "DefaultFunctionalities", "childcount": "0" },
             // { "id": "2", "name": "Conditional Formatting", "action": "ConditionalFormatting", "childcount": "0"},
          // // { "id": "3", "name": "Master Detail", "action": "MasterDetail", "childcount": "0" },								
          // // { "id": "4", "name": "Side By Side", "action": "SidebySide", "childcount": "0" },
             // { "id": "5", "name": "Mail Merge", "action": "MailMerge", "childcount": "0" },
             // { "id": "6", "name": "Grouping", "action": "Grouping", "childcount": "0" },
             // { "id": "7", "name": "Product Catalogue", "action": "ProductCatalog", "childcount": "0"},
          // // { "id": "8", "name": "DrillThrough", "action": "DrillThrough", "childcount": "0"},	
             // { "id": "9", "name": "Row Formatting", "action": "RowFormatting", "childcount": "0" },
             // { "id": "10", "name": "Product Line Sales", "action": "ProductLineSales", "childcount": "0" },								
             // { "id": "11", "name": "Product Sales Analysis", "action": "ProductSalesAnalysis", "childcount": "0" },
			 // { "id": "12", "name": "Product List", "action": "ProductList", "childcount": "0" },
			 // { "id": "13", "name": "Sales Per Year", "action": "SalesPerYear", "childcount": "0" },
             // { "id": "14", "name": "SalesDashboard", "action": "SalesDashboard", "childcount": "0" },
		  // // { "id": "15", "name": "Sales By Region", "action": "SalesbyRegion", "childcount": "0" },
			 // { "id": "16", "name": "InvoiceTemplate", "action": "InvoiceTemplate", "childcount": "0" }
		  // // { "id": "17", "name": "Grouping Aggregate", "action": "GroupingAggregate", "childcount": "0" }
                // ]
    // },		
{
    "name": "RadialMenu",
    "id": "RadialMenu",
    "childcount": "1",
    "Group": "NAVIGATION",
    "isResponsive": "false",
    "action": "DefaultFunctionalities",
    "samples": [
        { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
        { "id": "2", "name": "Nested Radial Menu", "action": "NestedRadialMenu", "childcount": "0" }

    ]
},
    {
        "name": "ReportViewer",
        "id": "ReportViewer",
        "childcount": "1",
        "Group": "REPORTING",
        "action": "DefaultFunctionalities",
        "isResponsive": "false",
        "samples": [
            {
                "id": "1", "name": "SSRS", "action": "DefaultFunctionalities", "childcount": "0"
            },
            {
                "id": "2", "name": "Data Binding", "action": "DataBindingRemote", "childcount": "1",
                "samples": [
                                { "id": "1", "name": "Remote Data", "action": "DataBindingRemote", "childcount": "0" },
                                { "id": "2", "name": "Local Data", "action": "DataBindingLocal", "childcount": "0" }
                ]
            },
            {
                "id": "4", "name": "Conditional Formatting", "action": "ConditionalFormatting", "childcount": "0"
            },
            {
                "id": "5", "name": "Master Detail", "action": "MasterDetail", "childcount": "0"
            },
            {
                "id": "6", "name": "Side By Side", "action": "SidebySide", "childcount": "0"
            },
            {
                "id": "7", "name": "Mail Merge", "action": "MailMerge", "childcount": "0"
            },
            {
                "id": "8", "name": "Interactive Reports", "action": "DrillDown", "childcount": "1",
                "samples": [
                                { "id": "1", "name": "DrillDown", "action": "DrillDown", "childcount": "0" },
                                //{ "id": "2", "name": "DocumentMap", "action": "DocumentMap", "childcount": "0" },
                                { "id": "3", "name": "DrillThrough", "action": "DrillThrough", "childcount": "0" }
                ]
            },
            {
                "id": "9", "name": "Localization", "action": "Localization", "childcount": "0"
            },
            {
                "id": "10", "name": "Usage Scenario", "action": "ProductLineSales", "childcount": "1",
                "samples": [
                                { "id": "1", "name": "Product Line Sales", "action": "ProductLineSales", "childcount": "0" },
                                { "id": "2", "name": "Sales Analysis", "action": "ProductSalesAnalysis", "childcount": "0" },
								{ "id": "3", "name": "Product List", "action": "ProductList", "childcount": "0" },
                                { "id": "4", "name": "Company Sales", "action": "SalesPerYear", "childcount": "0" },
                                { "id": "5", "name": "SalesDashboard", "action": "SalesDashboard", "childcount": "0" }
                ]
            }
        ]
    },

     {
         "name": "OlapClient", "Group": "BUSINESS INTELLIGENCE", "id": "OlapClient", "childcount": "1", "action": "Default", "type": "", "isResponsive": "false", "samples": [
              { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
              { "id": "2", "name": "Customization", "action": "Customization", "childcount": "0" },
              { "id": "3", "name": "Localization", "action": "Localization", "childcount": "0" },
              { "id": "4", "name": "Exporting Modes", "action": "ExportingModes", "childcount": "0" },
              { "id": "5", "name": "Defer Update", "action": "DeferUpdate", "childcount": "0", "type": "" }
         ]
     },
     {
         "name": "PivotGrid", "id": "PivotGrid", "Group": "BUSINESS INTELLIGENCE", "childcount": "1", "action": "Default", "type": "update", "isResponsive": "false", "samples": [
              {
                  "id": "1", "name": "Relational", "action": "PivotGrid", "childcount": "1", "samples": [
                      { "id": "1", "name": "Getting Started", "action": "Default", "childcount": "0", "type": "new" },
                      { "id": "2", "name": "Grouping Bar", "action": "GroupingBar", "childcount": "0", "type": "new" },
                      { "id": "3", "name": "Field List", "action": "PivotFieldList", "childcount": "0", "type": "new" },
                      { "id": "4", "name": "Summary Type", "action": "SummaryType", "childcount": "0", "type": "new" },
                      { "id": "5", "name": "Server-side", "action": "ServerSide", "childcount": "0" }
                  ]
              },
              {
                  "id": "2", "name": "OLAP", "action": "PivotGrid", "childcount": "1", "samples": [
                      { "id": "1", "name": "Getting Started", "action": "Olap", "childcount": "0" },
                      { "id": "2", "name": "Field List", "action": "OlapFieldList", "childcount": "0" },
                      { "id": "3", "name": "Drill Position", "action": "DrillPosition", "childcount": "0" },
                      { "id": "4", "name": "KPI", "action": "KPI", "childcount": "0" },
                      { "id": "5", "name": "Layout", "action": "Layout", "childcount": "0" },
                      { "id": "6", "name": "Paging", "action": "Paging", "childcount": "0" },
                      { "id": "7", "name": "Exporting", "action": "OlapExporting", "childcount": "0" }
                  ]
              },
              {
                  "id": "3", "name": "Common", "action": "PivotGrid", "childcount": "1", "samples": [
                      { "id": "1", "name": "Hyperlink", "action": "Hyperlink", "childcount": "0" },
                      { "id": "2", "name": "Conditional Formatting", "action": "ConditionalFormatting", "childcount": "0" },
                      { "id": "3", "name": "Cell Selection", "action": "CellSelection", "childcount": "0" },
                      { "id": "4", "name": "Cell Context", "action": "CellContext", "childcount": "0" },
                      { "id": "5", "name": "Localization", "action": "Localization", "childcount": "0" },
                      { "id": "6", "name": "RTL", "action": "RTL", "childcount": "0" },
                      { "id": "7", "name": "Events", "action": "Events", "childcount": "0" }
                  ]
              }
         ]
     },
     {
         "name": "OlapChart", "id": "OlapChart", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "action": "Default", "type": "update", "isResponsive": "false", "samples": [
         { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Chart Types", "action": "ChartTypes", "childcount": "0", "type": "update" },
         { "id": "3", "name": "Events", "action": "Events", "childcount": "0" },
         { "id": "4", "name": "Localization", "action": "Localization", "childcount": "0" },
         { "id": "5", "name": "Exporting", "action": "Exporting", "childcount": "0", "type": "" },
         { "id": "6", "name": "3DChart", "action": "3DChart", "childcount": "0", "type": "" }
         ]
     },
     {
         "name": "OlapGauge", "id": "OlapGauge", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "action": "Default", "type": "", "isResponsive": "false", "samples": [
         { "id": "1", "name": "Default Functionalities", "action": "Default", "childcount": "0" },
         { "id": "2", "name": "Events", "action": "Events", "childcount": "0" },
         { "id": "3", "name": "Layout", "action": "Layout", "childcount": "0" },
         { "id": "4", "name": "Localization", "action": "Localization", "childcount": "0", "type": "" },
         { "id": "5", "name": "Pointer", "action": "Pointer", "childcount": "0" },
         { "id": "6", "name": "Range", "action": "Range", "childcount": "0" },
         { "id": "7", "name": "Scale", "action": "Scale", "childcount": "0" }
         ]
     },
	    {
	        "name": "Presentation",
	        "id": "Presentation",
			"type": "update",
	        "childcount": "1",
	        "Group": "FILE FORMATS",
	        "action": "DefaultFunctionality",
	        "samples": [
                 { "id": "1", "name": "Default", "action": "DefaultFunctionality", "childcount": "0" },
                 {
                     "id": "2", "name": "Product Showcase", "action": "PresentationViewer", "childcount": "1", samples: [
                       //first hierarchy
                             { "id": "21", "name": "Presentation Viewer", "action": "PresentationViewer", "childcount": "0" }]
                 },
                 {
                     "id": "3", "name": "Getting Started", "action": "HelloWorld", "childcount": "1", samples: [
                     //second hierarchy
                           { "id": "31", "name": "Hello World", "action": "HelloWorld", "childcount": "0" }]
                 },
                  {
                      "id": "4", "name": "Slide Elements", "action": "Images", "childcount": "1", samples: [
                     //third hierarchy
                           { "id": "41", "name": "Images", "action": "Images", "childcount": "0" },
                           { "id": "42", "name": "Slides", "action": "Slides", "childcount": "0" },
                           { "id": "43", "name": "Tables", "action": "Tables", "childcount": "0" }]
                  },
                   {
                       "id": "5", "name": "Conversion", "action": "PPTXToImage", "childcount": "1", samples: [
                      //fourth hierarchy
                            { "id": "51", "name": "PPTX To Image", "action": "PPTXToImage", "childcount": "0" },
                            { "id": "52", "name": "PPTX To PDF", "action": "PPTXToPdf", "childcount": "0" }]
                   },
                    {
                        "id": "6", "name": "Clone and Merge", "action": "Cloning Slides", "childcount": "1", samples: [
                       //fifth hierarchy
                             { "id": "61", "name": "Cloning Slide", "action": "CloningSlides", "childcount": "0" },
                             { "id": "62", "name": "Merging Presentations", "action": "MergingPresentation", "childcount": "0" }]
                    },
                     {
                         "id": "7", "name": "Security", "action": "EncryptAndDecrypt", "childcount": "1", samples: [
                        //sixth hierarchy
                              { "id": "71", "name": "Encryption and Decryption", "action": "EncryptAndDecrypt", "childcount": "0" }]

                     },
                      {
                          "id": "8", "name": "SmartArt", "action": "SmartArt Creation", "childcount": "1", samples: [
                         //seventh hierarchy
                               { "id": "81", "name": "SmartArt Creation", "action": "SmartArtCreation", "type": "new", "childcount": "0" },
                               { "id": "82", "name": "Manipulating SmartArt", "action": "ManipulatingSmartArt", "type": "new", "childcount": "0" },
                               { "id": "83", "name": "Customizing Appearance", "action": "CustomizingAppearance", "type": "new", "childcount": "0" }]
                      }
	        ]

	    },

      {
          "name": "XlsIO",
          "id": "XlsIO",
          "childcount": "1",
          "Group": "FILE FORMATS",
          "action": "DefaultFunctionalities",
          "samples": [
          { "id": "1", "name": "Default", "action": "DefaultFunctionalities", "childcount": "0" },
                      {
                          "id": "2", "name": "Product Showcase", "action": "BudgetPlanner", "childcount": "1", "samples": [
                              { "id": "1", "name": "Budget Planner", "action": "BudgetPlanner", "childcount": "0" },
                               { "id": "2", "name": "Stock Portfolio", "action": "StockPortFolio", "childcount": "0" },
                              { "id": "3", "name": "Excel To PDF", "action": "ExcelToPDF", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "3", "name": "Getting Started", "action": "CreateSpreadsheet", "childcount": "1", "samples": [
                              { "id": "1", "name": "Create", "action": "CreateSpreadsheet", "childcount": "0" },
                              { "id": "2", "name": "Find And Extract", "action": "FindAndExtract", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "4", "name": "Formatting", "action": "FormatCells", "childcount": "1", "samples": [
                              { "id": "1", "name": "Format Cells", "action": "FormatCells", "childcount": "0" },
                              { "id": "2", "name": "Styles And Formatting", "action": "StylesAndFormatting", "childcount": "0" },
                              { "id": "3", "name": "Conditional Formatting", "action": "ConditionalFormatting", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "5", "name": "Charts", "action": "ChartWorksheet", "childcount": "1", "samples": [
                              { "id": "1", "name": "Chart Worksheet", "action": "ChartWorksheet", "childcount": "0" },
                              { "id": "2", "name": "Embedded Chart", "action": "EmbeddedChart", "childcount": "0" },
                              { "id": "3", "name": "Sparklines", "action": "Sparklines", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "6", "name": "Data Management", "action": "RangeManipulation", "childcount": "1", "samples": [
                              { "id": "1", "name": "Range Manipulation", "action": "RangeManipulation", "childcount": "0" },
                              { "id": "2", "name": "Formulas", "action": "Formulas", "childcount": "0" },
                              { "id": "3", "name": "Compute All formulas", "action": "ComputeAllformulas", "childcount": "0" },
                              { "id": "4", "name": "Data Validation", "action": "DataValidation", "childcount": "0" },
                              { "id": "5", "name": "Performance", "action": "Performance", "childcount": "0" },
                              { "id": "6", "name": "Interactive Features", "action": "InteractiveFeatures", "childcount": "0" },
                              { "id": "7", "name": "Form Controls", "action": "FormControls", "childcount": "0" },
                              { "id": "8", "name": "Data Sorting", "action": "Sorting", "childcount": "0" }
                          ]

                      },
                      {
                          "id": "7", "name": "Data Binding", "action": "ExternalConnection", "childcount": "1", "type": "update", "samples": [
                              { "id": "1", "name": "External Connection", "action": "ExternalConnection", "childcount": "0" },
                              { "id": "2", "name": "Template Marker", "action": "TemplateMarker", "childcount": "0" },
                              { "id": "3", "name": "Business Objects", "action": "BussinessObjects", "childcount": "0" },
                              { "id": "4", "name": "Sales Invoice", "action": "SalesInvoice", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "8", "name": "Sheet Management", "action": "RowColumnManipulations", "childcount": "1", "samples": [
                              { "id": "1", "name": "Row-Column Manipulation", "action": "RowColumnManipulations", "childcount": "0" },
                              { "id": "2", "name": "Worksheet Management", "action": "WorksheetManagement", "childcount": "0" },
                              { "id": "3", "name": "Worksheet To Image", "action": "WorksheetToImage", "childcount": "0" },
                              { "id": "4", "name": "Worksheet To HTML", "action": "WorksheetToHTML", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "9", "name": "Settings", "action": "DocumentProperties", "childcount": "1", "samples": [
                              { "id": "1", "name": "Document Settings", "action": "DocumentProperties", "childcount": "0" },
                              { "id": "2", "name": "Worksheet Protection", "action": "WorksheetProtection", "childcount": "0" },
                              { "id": "3", "name": "Workbook Protection", "action": "WorkbookProtection", "childcount": "0" },
                              { "id": "4", "name": "Encrypt and Decrypt", "action": "EncryptionDecryption", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "10", "name": "Business Intelligence", "action": "Tables", "childcount": "1", "samples": [
                              { "id": "1", "name": "Tables", "action": "Tables", "childcount": "0" },
                              { "id": "2", "name": "Pivot Table", "action": "PivotTable", "childcount": "0" },
                              { "id": "3", "name": "Pivot Chart", "action": "PivotChart", "childcount": "0" }
                          ]
                      },
                      {
                          "id": "11", "name": "Shapes", "action": "AutoShapes", "childcount": "1", "samples": [
                              { "id": "1", "name": "AutoShapes", "action": "AutoShapes", "childcount": "0" }
                          ]
                      }
          ]
      },

       {
           "name": "PDF",
           "id": "PDF",
           "childcount": "1",
           "Group": "FILE FORMATS",
           "action": "JobApplication",
           "samples": [


               {
                   "id": "2", "name": "Product Showcase", "action": "JobApplication", "childcount": "2", samples: [
                   //second hierarchy
				   { "id": "21", "name": "Job Application", "action": "JobApplication", "childcount": "0" },
                         { "id": "22", "name": "Invoice Sample", "action": "Invoice", "childcount": "0" }]
               },
               {
                   "id": "3", "name": "Getting Started", "action": "HelloWorld", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "31", "name": "Hello World", "action": "HelloWorld", "childcount": "0" },
                         { "id": "32", "name": "PDF-A Sample", "action": "PDFA", "childcount": "0" },
                         { "id": "33", "name": "PDF Compression", "action": "PDFCompression", "childcount": "0" }]
               },
               {
                   "id": "4", "name": "Drawing Text", "action": "TextFlow", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "41", "name": "Text Flow", "action": "TextFlow", "childcount": "0" },
                         { "id": "42", "name": "RTL Support", "action": "RTLSupport", "childcount": "0" },
                         { "id": "43", "name": "Bullets and Lists", "action": "BulletsAndLists", "childcount": "0" },
                         { "id": "44", "name": "Multi Column Text", "action": "MultiColumnText", "childcount": "0" }]
               },
               {
                   "id": "5", "name": "Graphics", "action": "Barcode", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "51", "name": "Barcode", "action": "Barcode", "childcount": "0" },
                         { "id": "52", "name": "Drawing Shapes", "action": "DrawingShapes", "childcount": "0" },
                         { "id": "53", "name": "Drawing Graphics", "action": "DrawingGraphics", "childcount": "0" },
                         { "id": "54", "name": "Inserting Images", "action": "InsertingImages", "childcount": "0" },
                         { "id": "55", "name": "Layers", "action": "Layers", "childcount": "0" }]
               },
               {
                   "id": "6", "name": "Tables", "action": "NorthwindReport", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "61", "name": "Northwind Report", "action": "NorthwindReport", "childcount": "0" },
                         { "id": "62", "name": "Table Features", "action": "TableFeatures", "childcount": "0" }]
               },
               {
                   "id": "7", "name": "Settings", "action": "DocumentProperties", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "71", "name": "Document Properties", "action": "DocumentProperties", "childcount": "0" },
                         { "id": "72", "name": "Page Settings", "action": "PrintSettings", "childcount": "0" },
                         { "id": "73", "name": "Header and Footer", "action": "HeaderFooter", "childcount": "0" }]
               },
               {
                   "id": "8", "name": "Security", "action": "Encryption Support", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "81", "name": "Encryption Support", "action": "EncryptionSupport", "childcount": "0" },
                         { "id": "82", "name": "Digital Signature", "action": "DigitalSignature", "childcount": "0" }]
               },
               {
                   "id": "9", "name": "User Interaction", "action": "InteractiveFeatures", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "91", "name": "Interactive Features", "action": "InteractiveFeatures", "childcount": "0" },
                         { "id": "92", "name": "Form Filling", "action": "FormFilling", "childcount": "0" },
                         { "id": "93", "name": "Portfolio", "action": "Portfolio", "childcount": "0" }]
               },
               {
                   "id": "10", "name": "Import and Export", "action": "TextExtraction", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "101", "name": "Text Extraction", "action": "TextExtraction", "childcount": "0" },
                         { "id": "102", "name": "Doc to PDF", "action": "DocToPdf", "childcount": "0" },
                         { "id": "103", "name": "Excel to PDF", "action": "ExceltoPDF", "childcount": "0" },
                         { "id": "104", "name": "HTML to PDF", "action": "HtmlToPdf", "childcount": "0" },
                         { "id": "105", "name": "XPS to PDF", "action": "XPStoPDF", "childcount": "0" },
                         { "id": "106", "name": "RTF Support", "action": "RTFSupport", "childcount": "0" }]
               },
               {
                   "id": "11", "name": "Modify Documents", "action": "MergeDocuments", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "111", "name": "Merge Documents", "action": "MergeDocuments", "childcount": "0" },
                         { "id": "112", "name": "Split PDF", "action": "SplitPDF", "childcount": "0" },
                         { "id": "113", "name": "Overlay Documents", "action": "OverlayDocuments", "childcount": "0" },
                         { "id": "114", "name": "Booklet", "action": "Booklet", "childcount": "0" },                         
                         { "id": "115", "name": "Import and Stamp", "action": "ImportAndStamp", "childcount": "0" }]
               },
               {
                   "id": "12", "name": "OCR", "action": "PDFOCR", "childcount": "1", samples: [
                   //second hierarchy
                         { "id": "121", "name": "PDF OCR", "action": "PDFOCR", "childcount": "0" }]
               }]
       },

        {
            "name": "DocIO",
            "id": "DocIO",
            "childcount": "1",
            "Group": "FILE FORMATS",
            "action": "DefaultFunctionalities",
            "samples": [
             { "id": "1", "name": "Default", "action": "DefaultFunctionalities", "childcount": "0" },


                            {
                                "id": "2", "name": "Product Showcase", "action": "SalesInvoice", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Sales Invoice", "action": "SalesInvoice", "childcount": "0" },
                                         { "id": "2", "name": "Update Fields", "action": "UpdateFields", "childcount": "0" }
                                ]
                            },
                            {
                                "id": "3", "name": "Getting Started", "action": "HelloWorld", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Hello World", "action": "HelloWorld", "childcount": "0" }
                                ]
                            },
                           {
                               "id": "4", "name": "Editing", "action": "ReplaceWithFormating", "childcount": "1", "samples": [
                                        { "id": "1", "name": "Advanced Replace", "action": "ReplaceWithFormating", "childcount": "0" },
                                        { "id": "2", "name": "Bookmark Navigation", "action": "BookmarkNavigation", "childcount": "0" },
                                        { "id": "3", "name": "Forms", "action": "Forms", "childcount": "0" }
                               ]
                           },
                           {
                               "id": "5", "name": "Formatting", "action": "FormatTable", "childcount": "1", "samples": [
                                        { "id": "1", "name": "Format Table", "action": "FormatTable", "childcount": "0" },
                                        { "id": "2", "name": "Format Text", "action": "FormatText", "childcount": "0" },
                                        { "id": "3", "name": "RTL Support", "action": "RTLSupport", "childcount": "0" },
                                        { "id": "4", "name": "Styles", "action": "Styles", "childcount": "0" },
                                        { "id": "5", "name": "Table Styles", "action": "TableStyles", "childcount": "0" }
                               ]
                           },
                           {
                               "id": "6", "name": "Insert Content", "action": "Bookmarks", "childcount": "1", "samples": [
                                        { "id": "1", "name": "Bookmarks", "action": "Bookmarks", "childcount": "0" },
                                        { "id": "2", "name": "Clone and Merge", "action": "CloneandMerge", "childcount": "0" },
                                        { "id": "3", "name": "Header and Footer", "action": "HeaderandFooter", "childcount": "0" },
                                        { "id": "4", "name": "Image Insertion", "action": "ImageInsertion", "childcount": "0" },
                                        { "id": "5", "name": "Insert OLE Object", "action": "InsertOLEObject", "childcount": "0" }
                               ]
                           },
                           {
                               "id": "7", "name": "Mail Merge", "action": "EmployeeReport", "childcount": "1", "samples": [
                                        { "id": "1", "name": "Employee Report", "action": "EmployeeReport", "childcount": "0" },
                                        { "id": "2", "name": "Mail Merge Event", "action": "MailMergeEvent", "childcount": "0" },
                                        { "id": "3", "name": "Nested Mail Merge", "action": "NestedMailMerge", "childcount": "0" }
                               ]
                           },
                           {
                               "id": "8", "name": "Page Layout", "action": "InsertBreak", "childcount": "1", "samples": [
                                        { "id": "1", "name": "Insert Break", "action": "InsertBreak", "childcount": "0" },
                                        { "id": "2", "name": "Watermark", "action": "Watermark", "childcount": "0" }
                               ]
                           },
                            {
                                "id": "9", "name": "View", "action": "DocumentSettings", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Document Settings", "action": "DocumentSettings", "childcount": "0" },
                                         { "id": "2", "name": "Macro Preservation", "action": "MacroPreservation", "childcount": "0" }
                                ]
                            },
                            {
                                "id": "10", "name": "Security", "action": "DocumentProtection", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Document Protection", "action": "DocumentProtection", "childcount": "0" },
                                         { "id": "2", "name": "Encrypt and Decrypt", "action": "EncryptandDecrypt", "childcount": "0" }
                                ]
                            },
                            {
                                "id": "11", "name": "References", "action": "FootnotesandEndnotes", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Footnotes and Endnotes", "action": "FootnotesandEndnotes", "childcount": "0" },
                                         { "id": "2", "name": "Table of Contents", "action": "TableofContents", "childcount": "0" }
                                ]
                            },
                            {
                                "id": "12", "name": "Import and Export", "action": "DOCToEPub", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Word to HTML", "action": "DocToHTML", "childcount": "0" },
                                         { "id": "2", "name": "Word to RTF", "action": "DocToRTF", "childcount": "0" },
                                         { "id": "3", "name": "Word to Image", "action": "WordtoImage", "childcount": "0" },
                                         { "id": "4", "name": "Word to PDF", "action": "DOCtoPDF", "childcount": "0" },
                                         { "id": "5", "name": "HTML to Word", "action": "HTMLtoDOC", "childcount": "0" },
                                         { "id": "6", "name": "RTF to Word", "action": "RTFToDoc", "childcount": "0" },
                                         { "id": "7", "name": "Word to EPub", "action": "DOCToEPub", "childcount": "0" }
                                ]
                            },
                             {
                                 "id": "13", "name": "Shapes", "action": "AutoShapes", "childcount": "1", "samples": [
                                          { "id": "1", "name": "AutoShapes", "action": "AutoShapes", "childcount": "0" }
                                 ]
                             },
                             {
                                 "id": "14", "name": "Chart", "action": "Pie Chart", "childcount": "1", "samples": [
                                          { "id": "1", "name": "Pie Chart", "action": "PieChart", "childcount": "0" },
                                          { "id": "2", "name": "Bar Chart", "action": "BarChart", "childcount": "0" }
                                 ]
                             }
            ]
        },
         {
             "name": "Predictive Analytics", "Group": "DATA SCIENCE", "id": "Analytics", "childcount": "0", "action": "Sample", "isResponsive": "false", "samples": []
         },

    {
        "name": "RichTextEditor",
        "id": "RichTextEditor",
        "childcount": "1",
        "Group": "EDITORS",
        "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "21", "name": "Default Functionalities", "action": "DefaultFunctionalities", "isResponsive": "true", "childcount": "0" },
            { "id": "22", "name": "All Tools", "action": "AllTools", "childcount": "0", "isResponsive": "true" },
            { "id": "23", "name": "Custom Tool", "action": "CustomTool", "childcount": "0", "isResponsive": "true" },
            { "id": "24", "name": "API's", "action": "API", "childcount": "0", "isResponsive": "true" },
            { "id": "25", "name": "Client-Side Events", "action": "Events", "childcount": "0", "isResponsive": "true" },
            { "id": "26", "name": "Localization", "action": "Localization", "childcount": "0", "isResponsive": "true" },
            { "id": "27", "name": "File & Image Browser", "action": "FileAndImageBrowser", "childcount": "0", "isResponsive": "false" },
            { "id": "29", "name": "RTL", "action": "RTL", "childcount": "0", "isResponsive": "true" },
            { "id": "30", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0", "isResponsive": "true" }
        ]
    },
    {
        "name": "FileExplorer",
        "id": "FileExplorer",
        "childcount": "1",
        "Group": "NAVIGATION", "isResponsive": "false",
        "type": "update",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "type": "update", "childcount": "0" },
            { "id": "2", "name": "Custom Tool", "action": "CustomTool", "childcount": "0" },
            { "id": "3", "name": "API's", "action": "API", "childcount": "0", "type": "update", "isResponsive": "true" },
            { "id": "4", "name": "Client-Side Events", "action": "Events", "childcount": "0", "isResponsive": "true" },
            { "id": "5", "name": "Localization", "action": "Localization", "childcount": "0", "isResponsive": "true" },
            { "id": "6", "name": "RTL", "action": "RTL", "childcount": "0", "type": "update", "isResponsive": "true" },
            { "id": "7", "name": "Keyboard Interaction", "action": "KeyboardNavigation", "childcount": "0", "isResponsive": "true" }
        ]
    },

    {
        "name": "TreeView",
        "id": "TreeView",
        "childcount": "1",
        "Group": "NAVIGATION", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           { "id": "2", "name": "Icons", "action": "Icons", "childcount": "0" },
           { "id": "3", "name": "Checkboxes", "action": "Checkbox", "childcount": "0" },
           { "id": "4", "name": "Node Editing-Cut-Paste", "action": "NodeEditing-Copy-Paste", "childcount": "0" },
           { "id": "5", "name": "Drag and Drop", "action": "DragandDrop", "childcount": "0" },
           {
               "id": "6", "name": "Data Binding", "action": "Databinding-remote", "childcount": "1",
               "samples": [
                   { "id": "7", "name": "Remote Data", "action": "Databinding-remote", "childcount": "0" },
                   { "id": "18", "name": "SQL Data", "action": "DataBinding-SqlData", "childcount": "0" },
                   { "id": "19", "name": "Object Data", "action": "DataBinding-Object", "childcount": "0" },
                   { "id": "20", "name": "XML Data", "action": "DataBinding-Xml", "childcount": "0" },
                   { "id": "21", "name": "LinqToSQL", "action": "DataBinding-LinqToSql", "childcount": "0" }
               ]
           },
           { "id": "8", "name": "Load On Demand", "action": "LoadOnDemand", "childcount": "0" },
           { "id": "9", "name": "Template", "action": "Template", "childcount": "0" },
           { "id": "10", "name": "Context Menu", "action": "ContextMenu", "childcount": "0" },
           { "id": "11", "name": "State Maintenance", "action": "StateMaintenance", "childcount": "0" },
           { "id": "14", "name": "API's", "action": "APIs", "childcount": "0" },
           { "id": "15", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "16", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
           { "id": "17", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "18", "name": "Keyboard Interactions", "action": "KeyboardInteractions", "childcount": "0" }
        ]
    },
    {
        "name": "ColorPicker",
        "id": "ColorPicker",
        "childcount": "1",
        "Group": "EDITORS", "isResponsive": "true",
        "type": "update",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Display Inline", "action": "Display-Inline", "childcount": "0" },
            { "id": "3", "name": "Color Palette", "action": "PaletteModel", "childcount": "0" },
            { "id": "4", "name": "Presets", "action": "Presets", "childcount": "0" },
            { "id": "5", "name": "Custom Palette", "action": "CustomPalette", "childcount": "0" },
            { "id": "9", "name": "API's", "action": "APIs", "type": "update", "childcount": "0" },
            { "id": "10", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "11", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "13", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
        ]
    },
    {
        "name": "DatePicker",
        "id": "DatePicker",
        "childcount": "1",
        "Group": "EDITORS", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Date Format", "action": "Date-Format", "childcount": "0" },
            { "id": "3", "name": "Date Range", "action": "Date-Range", "childcount": "0" },
            { "id": "4", "name": "Display Inline", "action": "Display-Inline", "childcount": "0" },
            { "id": "5", "name": "Dates in Other Month", "action": "Dates-in-Other-Month", "childcount": "0" },
            { "id": "6", "name": "Localization", "action": "Localization", "childcount": "0" },
            { "id": "9", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "10", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "11", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "12", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "13", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
        ]
    },

    {
        "name": "TimePicker",
        "id": "TimePicker",
        "childcount": "1",
        "Group": "EDITORS", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Localization", "action": "Localization", "childcount": "0" },
            { "id": "5", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "6", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "7", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "8", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "9", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
        ]
    },

    {
        "name": "DateTimePicker",
        "id": "DateTimePicker",
        "childcount": "1",
        "type": "update",
        "Group": "EDITORS", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Localization", "action": "Localization", "childcount": "0" },
            { "id": "3", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "4", "name": "Drilldown Support", "action": "Drilldown", "childcount": "0", "type": "new" },
            { "id": "5", "name": "Meridian Format", "action": "Meridian", "childcount": "0", "type": "new" },
            { "id": "6", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "7", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "8", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "9", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
        ]
    },

    {
        "name": "Textboxes",
        "id": "Textboxes",
        "childcount": "1",
        "Group": "EDITORS", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Localization", "action": "Localization", "childcount": "0" },
            { "id": "5", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "7", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "8", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "9", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "10", "name": "Keyboard Interactions", "action": "KeyboardInteractions", "childcount": "0" }

        ]
    },

    {
        "name": "AutoComplete",
        "id": "AutoComplete",
        "childcount": "1",
        "Group": "EDITORS", "isResponsive": "true",
        "action": "DefaultFunctionalities",
        "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Multiple Values", "action": "MultipleValues", "childcount": "0" },
            { "id": "3", "name": "Grouping", "action": "Grouping", "childcount": "0" },
            { "id": "4", "name": "Template", "action": "Template", "childcount": "0" },
            {
                "id": "5", "name": "Data Binding", "action": "Databinding-Remote", "childcount": "1",
                "samples": [
                    { "id": "20", "name": "Databinding-Local", "action": "Databinding-Local", "childcount": "0" },
                    { "id": "6", "name": "Remote Data", "action": "Databinding-Remote", "childcount": "0" },
                    { "id": "16", "name": "SQL Data", "action": "DataBinding-SqlData", "childcount": "0" },
                    { "id": "17", "name": "Object Data", "action": "DataBinding-ObjectData", "childcount": "0" },
                    { "id": "18", "name": "Databinding-XML Data", "action": "DataBinding-XmlData", "childcount": "0" },
                    { "id": "19", "name": "LinqToSQL Data", "action": "DataBinding-LinqToSql", "childcount": "0" }
                ]
            },
            { "id": "7", "name": "Auto Fill", "action": "AutoFill", "childcount": "0" },
            { "id": "10", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "11", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
            { "id": "12", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
            { "id": "13", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "14", "name": "Keyboard Interactions", "action": "KeyboardInteractions", "childcount": "0" }

        ]
    },
     {
         "name": "Rotator",
         "id": "Rotator", "isResponsive": "true",
         "childcount": "1",
         "Group": "NAVIGATION",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "Image With Content", "action": "ImagewithContent", "isResponsive": "false", "childcount": "0" },
             { "id": "3", "name": "Thumbnail", "action": "Thumbnail", "childcount": "0" },
             { "id": "4", "name": "Data Binding - Local", "action": "Databinding-Local", "childcount": "0" },
             { "id": "7", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "8", "name": "Client-Side Events", "action": "Events", "childcount": "0" },
             { "id": "9", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
         ]
     },

     {
         "name": "Tab",
         "id": "Tab",
         "childcount": "1",
         "Group": "NAVIGATION", "isResponsive": "false",
         "action": "DefaultFunctionalities",
         "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           { "id": "2", "name": "Ajax Content", "action": "AjaxContent", "childcount": "0" },
           { "id": "3", "name": "Images", "action": "Images", "childcount": "0" },
           { "id": "4", "name": "Header Orientation", "action": "HeaderOrientation", "childcount": "0" },
           { "id": "5", "name": "Close Button", "action": "CloseButton", "childcount": "0" },
           { "id": "6", "name": "Other Widgets", "action": "OtherWidgets", "childcount": "0" },
           { "id": "7", "name": "State Maintenance", "action": "StateMaintenance", "childcount": "0" },
           { "id": "8", "name": "Scrollable Tab", "action": "TabScroll", "childcount": "0" },
           { "id": "9", "name": "API's", "action": "API", "childcount": "0" },
           { "id": "10", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "11", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
           { "id": "12", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "13", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" }
         ]
     },
     {
         "name": "Menu",
         "id": "Menu",
         "childcount": "1",
         "Group": "NAVIGATION", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
         { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
         {
             "id": "23", "name": "Data Binding", "action": "Databinding-Remote", "childcount": "1",
             "samples": [
                //{ "id": "2", "name": "Databinding - Local", "action": "Databinding-Local", "childcount": "0" },
                { "id": "3", "name": "Remote Data", "action": "Databinding-Remote", "childcount": "0" },
                { "id": "15", "name": "Sql Data", "action": "DataBinding-Sql", "childcount": "0" },
                { "id": "16", "name": "Object Data", "action": "DataBinding-Object", "childcount": "0" },
                { "id": "17", "name": "XML Data", "action": "DataBinding-XML", "childcount": "0" },
                 { "id": "18", "name": "Linq-to-Sql Data", "action": "DataBinding-LinqtoSql", "childcount": "0" }
             ]
         },
         { "id": "4", "name": "Templates", "action": "Templates", "childcount": "0" },
         { "id": "5", "name": "Open Direction", "action": "OpenDirection", "childcount": "0" },
         { "id": "6", "name": "Vertical Menu", "action": "VerticalMenu", "childcount": "0" },
         { "id": "7", "name": "Context Menu", "action": "ContextMenu", "childcount": "0" },
         { "id": "8", "name": "Center Menu", "action": "CenterMenu", "childcount": "0" },
         { "id": "11", "name": "API's", "action": "APIs", "childcount": "0" },
         { "id": "12", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
         { "id": "13", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
         { "id": "14", "name": "RTL", "action": "RTL", "childcount": "0" },
         { "id": "15", "name": "Keyboard Interactions", "action": "KeyboardInteraction", "childcount": "0" }

         ]
     },

       {
           "name": "Barcode",
           "id": "Barcode",
           "childcount": "1",
           "Group": "DATA VISUALIZATION",
           "action": "DefaultFunctionalities",
           "isResponsive": "false",
           "samples": [
               { "id": "1", "name": "Getting Started", "action": "DefaultFunctionalities", "childcount": "0" }
           ]
       },

     {
         "name": "Accordion", "Group": "NAVIGATION", "id": "Accordion", "childcount": "1", "isResponsive": "true", "type": "update", "action": "DefaultFunctionalities", "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           { "id": "2", "name": "Ajax Content", "action": "AjaxContent", "childcount": "0" },
           { "id": "3", "name": "Multiple Open", "action": "MultipleOpen", "childcount": "0" },
           { "id": "4", "name": "Open On Hover", "action": "OpenOnHover", "childcount": "0" },
           { "id": "5", "name": "Icons", "action": "Icons", "childcount": "0" },
           { "id": "6", "name": "Nested Accordion", "action": "NestedAccordion", "childcount": "0" },
           { "id": "7", "name": "API's", "action": "API", "childcount": "0", "type": "update", },
           { "id": "8", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "9", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
           { "id": "10", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "11", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" }

         ]
     },
     {
         "name": "ProgressBar",
         "id": "ProgressBar", "isResponsive": "true",
         "childcount": "1",
         "Group": "NOTIFICATION",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "3", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
             //{ "id": "4", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
             { "id": "5", "name": "RTL", "action": "RTL", "childcount": "0" }
         ]
     },

     {
         "name": "Rating",
         "id": "Rating", "isResponsive": "true",
         "childcount": "1",
         "Group": "EDITORS",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "5", "name": "Precision", "action": "Precision", "childcount": "0" },
             { "id": "4", "name": "Orientation", "action": "Orientation", "childcount": "0" },
             { "id": "6", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "7", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
             { "id": "8", "name": "Server-Side Events", "action": "Events", "childcount": "0" }

         ]
     },
     {
         "name": "DropDownList",
         "id": "DropDownList",
         "childcount": "1",
         "Group": "EDITORS",
         "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           { "id": "3", "name": "Checkbox", "action": "CheckBox", "childcount": "0" },
           { "id": "21", "name": "Icons", "action": "Icons", "childcount": "0" },
           { "id": "4", "name": "Cascading", "action": "Cascading", "childcount": "0" },
           { "id": "5", "name": "Grouping", "action": "Grouping", "childcount": "0" },
           {
               "id": "6", "name": "Data Binding", "action": "DataBinding-remotedata", "childcount": "1",
               "samples": [
                   //{ "id": "21", "name": "Databinding-Local", "action": "DataBinding-locatdata", "childcount": "0" },
                   { "id": "16", "name": "Remote Data", "action": "DataBinding-remotedata", "childcount": "0" },
                   { "id": "17", "name": "SQL Data", "action": "DataBinding-SqlData", "childcount": "0" },
                   { "id": "18", "name": "Object Data", "action": "DataBinding-ObjectData", "childcount": "0" },
                   { "id": "19", "name": "XML Data", "action": "DataBinding-XmlData", "childcount": "0" },
                   { "id": "20", "name": "LinqToSQL Data", "action": "DataBinding-LinqToSql", "childcount": "0" }
               ]
           },
           { "id": "8", "name": "Multi-Select", "action": "MultiSelect", "childcount": "0" },
           { "id": "9", "name": "Template", "action": "Template", "childcount": "0" },
           { "id": "12", "name": "API's", "action": "API", "childcount": "0" },
           { "id": "13", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "14", "name": "Server-Side Events", "action": "Event", "childcount": "0" },
           { "id": "15", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "16", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" },
           { "id": "17", "name": "Integration with Widgets", "action": "IntegrationwithWidgets", "childcount": "0" },
           { "id": "18", "name": "Virtual Scrolling", "action": "VirtualScrolling", "childcount": "0" }

         ]
     },
     {
         "name": "ListBox",
         "id": "ListBox",
         "childcount": "1",
         "Group": "NAVIGATION", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Checkbox", "action": "CheckBox", "childcount": "0" },
            { "id": "3", "name": "Icons", "action": "Icons", "childcount": "0" },
          { "id": "4", "name": "Cascading", "action": "Cascading", "childcount": "0" },
          { "id": "5", "name": "Grouping", "action": "Grouping", "childcount": "0" },
           {
               "id": "6", "name": "Data Binding", "action": "DataBinding-remotedata", "childcount": "1",
               "samples": [
                   { "id": "22", "name": "Remote Data", "action": "DataBinding-remotedata", "childcount": "0" },
                   { "id": "23", "name": "SQL Data", "action": "DataBinding-SqlData", "childcount": "0" },
                   { "id": "24", "name": "Object Data", "action": "DataBinding-ObjectData", "childcount": "0" },
                   { "id": "25", "name": "XML Data", "action": "DataBinding-XmlData", "childcount": "0" },
                   { "id": "26", "name": "LinqToSQL Data", "action": "DataBinding-LinqToSql", "childcount": "0" },
                    { "id": "27", "name": "Local Data", "action": "DataBinding-locatdata", "childcount": "0" }
               ]
           },
           { "id": "8", "name": "Multi-Select", "action": "MultiSelect", "childcount": "0" },
           { "id": "9", "name": "Template", "action": "Template", "childcount": "0" },
           { "id": "17", "name": "Drag And Drop", "action": "DragAndDrop", "childcount": "0" },
          { "id": "18", "name": "Load on Demand", "action": "LoadOnDemand", "childcount": "0" },
          { "id": "19", "name": "Reordering", "action": "Reordering", "childcount": "0" },
          { "id": "20", "name": "Tool Tip", "action": "ToolTip", "childcount": "0" },
          //{ "id": "21", "name": "Virtual Scrolling", "action": "VirtualScrolling", "childcount": "0" },
          { "id": "12", "name": "API's", "action": "API", "childcount": "0" },
          { "id": "13", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
          { "id": "14", "name": "Server-Side Events", "action": "Event", "childcount": "0" },
          { "id": "15", "name": "RTL", "action": "RTL", "childcount": "0" },
          { "id": "16", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" }

         ]
     },
     {
         "name": "Slider",
         "id": "Slider",
         "childcount": "1",
         "Group": "EDITORS", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "Range Slider", "action": "RangeSlider", "childcount": "0" },
             { "id": "3", "name": "Vertical Slider", "action": "VerticalSlider", "childcount": "0" },
             { "id": "6", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "7", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
             { "id": "8", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
             { "id": "9", "name": "RTL", "action": "RTL", "childcount": "0" },
             { "id": "10", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
         ]
     },

     {
         "name": "Splitter",
         "id": "Splitter",
         "childcount": "1",
         "Group": "LAYOUT", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
            { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
            { "id": "2", "name": "Nested Splitter", "action": "NestedSplitter", "childcount": "0" },
            { "id": "3", "name": "Integration", "action": "Integration", "childcount": "0" },
            { "id": "4", "name": "Orientation", "action": "Orientation", "childcount": "0" },
            { "id": "5", "name": "API's", "action": "APIs", "childcount": "0" },
            { "id": "6", "name": "Client-Side Events", "action": "Events", "childcount": "0" },
            { "id": "7", "name": "RTL", "action": "RTL", "childcount": "0" },
            { "id": "8", "name": "Keyboard Interaction", "action": "Keyboard-Interaction", "childcount": "0" }
         ]
     },

     {
         "name": "TagCloud",
         "id": "TagCloud",
         "childcount": "1", "isResponsive": "true",
         "Group": "DATA VISUALIZATION",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "Data Binding - Remote", "action": "DataBinding-Remote", "childcount": "0" },
             { "id": "5", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
             { "id": "6", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
             { "id": "7", "name": "RTL", "action": "RTL", "childcount": "0" }
         ]
     },

     {
         "name": "Buttons",
         "id": "Buttons",
         "childcount": "1",
         "Group": "EDITORS",
         "action": "DefaultFunctionalities",
         "type": "update",
         "isResponsive": "true",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "Toggle Button", "action": "ToggleButton", "childcount": "0" },
             { "id": "3", "name": "Split Button", "action": "SplitButton", "childcount": "0" },
             { "id": "4", "name": "Repeat Buttons", "action": "RepeatButton", "childcount": "0" },
             { "id": "5", "name": "Radio Buttons", "action": "RadioButton", "childcount": "0" },
             { "id": "6", "name": "Group Button", "action": "GroupButton", "type": "new", "childcount": "0" },
             { "id": "7", "name": "CheckBox ", "action": "CheckBox", "childcount": "0" },
             { "id": "8", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "9", "name": "Client-Side Events", "action": "ClientSideEvents", "type": "update", "childcount": "0" },
             { "id": "10", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
             { "id": "11", "name": "RTL", "action": "RTL", "type": "update", "childcount": "0" }

         ]
     },

     {
         "name": "Toolbar", "Group": "NAVIGATION", "id": "Toolbar", "childcount": "1", "isResponsive": "true", "action": "DefaultFunctionalities", "samples": [
           { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           {
               "id": "2", "name": "Data Binding", "action": "DataBinding-RemoteData", "childcount": "1",
               "samples": [
                   { "id": "3", "name": "Remote Data", "action": "DataBinding-RemoteData", "childcount": "0" },
                   { "id": "11", "name": "SQL Data", "action": "DataBind-SqlData", "childcount": "0" },
                   { "id": "12", "name": "Object Data", "action": "DataBinding-ObjectData", "childcount": "0" },
                   { "id": "13", "name": "XML Data", "action": "DataBinding-Xml", "childcount": "0" },
                   { "id": "14", "name": "LinqToSQL Data", "action": "DataBinding-LinqToSql", "childcount": "0" }
               ]
           },
           { "id": "4", "name": "Orientation", "action": "Orientation", "childcount": "0" },
             { "id": "5", "name": "Template", "action": "Template", "childcount": "0" },
            { "id": "8", "name": "API's", "action": "API", "childcount": "0" },
           { "id": "9", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "10", "name": "Server-Side Events", "action": "Events", "childcount": "0" },

           { "id": "11", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "12", "name": "Keyboard Interaction", "action": "KeyboardInteraction", "childcount": "0" }


         ]
     },

     {
         "name": "WaitingPopup",
         "id": "WaitingPopup",
         "childcount": "1",
         "Group": "NOTIFICATION", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "Template", "action": "Template", "childcount": "0" }
         ]
     },

     {
         "name": "Dialog",
         "id": "Dialog",
         "childcount": "1",
         "Group": "LAYOUT", "isResponsive": "true",
         "action": "DefaultFunctionalities",
         "samples": [
           { "id": "1", "name": "DefaultFunctionalities", "action": "DefaultFunctionalities", "childcount": "0" },
           { "id": "2", "name": "Ajax Content", "action": "AjaxContent", "childcount": "0" },
           { "id": "3", "name": "Multiple Dialog", "action": "DialogMultiple", "childcount": "0", "isResponsive": "false" },
           { "id": "4", "name": "Action Buttons", "action": "CustomAction", "childcount": "0" },
           { "id": "5", "name": "Model Dialog", "action": "ModelDialog", "childcount": "0" },
           { "id": "6", "name": "API's", "action": "API", "childcount": "0" },
           { "id": "7", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
           { "id": "8", "name": "Server-Side Events", "action": "Events", "childcount": "0" },
           { "id": "9", "name": "RTL", "action": "RTL", "childcount": "0" },
           { "id": "10", "name": "Keyboard Interaction", "action": "KeyboardIntraction", "childcount": "0" }

         ]
     }, {
         "name": "ListView", "id": "ListView", "childcount": "1", "Group": "LAYOUT", "action": "DefaultFunctionalities", "isResponsive": "true", "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
               { "id": "2", "name": "CheckList", "action": "CheckList", "childcount": "0" },
                {
                    "id": "3", "name": "Data Binding", "action": "DataBinding-SqlData", "childcount": "1",
                    "samples": [

                        { "id": "4", "name": "SQL Data", "action": "DataBinding-SqlData", "childcount": "0" },
                        { "id": "11", "name": "Object Data", "action": "DataBinding-ObjectData", "childcount": "0" },
                        { "id": "12", "name": "XML Data", "action": "DataBinding-XMLData", "childcount": "0" },
                        { "id": "13", "name": "LinqToSQL Data", "action": "DataBinding-LinqToSql", "childcount": "0" }
                    ]
                },

              { "id": "5", "name": "Template", "action": "Template", "childcount": "0" }
         ]
     },
        {
            "name": "TileView",
            "id": "TileView",
            "childcount": "1",
            "Group": "LAYOUT", "isResponsive": "false",
            "action": "DefaultFunctionalities",
            "samples": [
              { "id": "1", "name": "DefaultFunctionalities", "action": "DefaultFunctionalities", "childcount": "0" }
            ]
        },

	   {
	       "name": "UploadBox", "Group": "EDITORS", "id": "UploadBox", "childcount": "1", "action": "DefaultFunctionalities", "isResponsive": "true", "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "File Input", "action": "FileInput", "childcount": "0" },
            { "id": "3", "name": "Drag And Drop", "action": "DragAndDrop", "childcount": "0" },
            { "id": "7", "name": "Synchronous Upload", "action": "SynchronousUpload", "childcount": "0" },
             { "id": "8", "name": "Web API Service", "action": "WebAPIService", "childcount": "0" },
             { "id": "4", "name": "API's", "action": "APIs", "childcount": "0" },
             { "id": "5", "name": "Client-Side Events", "action": "ClientSideEvents", "childcount": "0" },
             { "id": "6", "name": "Server-Side Events", "action": "Events", "childcount": "0" }
	       ]
	   },
       {
           "name": "ScrollBar", "id": "ScrollBar", "Group": "NAVIGATION", "childcount": "1", "action": "DefaultFunctionalities", "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
			 { "id": "2", "name": "Virtual Scrolling", "action": "VirtualScrolling", "childcount": "0" }
           ]
       },
     {
         "name": "NavigationDrawer",
         "id": "NavigationDrawer",
         "childcount": "1",
         "Group": "NAVIGATION", "isResponsive": "false",
         "action": "DefaultFunctionalities",
         "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" }

         ]
     },

	   {
	       "name": "Captcha", "id": "Captcha", "childcount": "1", "Group": "EDITORS", "action": "DefaultFunctionalities", "isResponsive": "true", "samples": [
             { "id": "1", "name": "Default Functionalities", "action": "DefaultFunctionalities", "childcount": "0" },
             { "id": "2", "name": "API's", "action": "CoreFeatures", "childcount": "0" },
             { "id": "3", "name": "Sign Up Form", "action": "SignUpForm", "childcount": "0" },
             { "id": "4", "name": "RTL", "action": "RTL", "childcount": "0" }
	       ]
	   },
       {
           "name": "AngularJS",
           "id": "AngularSupport",
           "childcount": "1",
           "Group": "INTEGRATION", "isResponsive": "true",
           "action": "AutoComplete",
           "samples": [
           { "id": "1", "name": "AutoComplete", "action": "AutoComplete", "childcount": "0" },
           { "id": "2", "name": "BulletGraph", "action": "BulletGraph", "childcount": "0" },
           { "id": "3", "name": "Chart", "action": "Chart", "childcount": "0" },
           { "id": "4", "name": "CircularGauge", "action": "CircularGauge", "childcount": "0" },
           { "id": "5", "name": "ColorPicker", "isResponsive": "false", "action": "ColorPicker", "childcount": "0" },
           { "id": "6", "name": "DatePicker", "action": "DatePicker", "childcount": "0" },
           { "id": "7", "name": "DateTimePicker", "action": "DateTimePicker", "childcount": "0" },
           { "id": "8", "name": "Diagram", "action": "Diagram", "childcount": "0" },
           { "id": "9", "name": "DigitalGauge", "action": "DigitalGauge", "childcount": "0" },
           { "id": "10", "name": "DropDownList", "action": "DropDownList", "childcount": "0" },
           { "id": "11", "name": "Gantt", "action": "Gantt", "childcount": "0" },
           { "id": "12", "name": "Grid", "action": "Grid", "childcount": "0" },
           { "id": "13", "name": "LinearGauge", "action": "LinearGauge", "childcount": "0" },
           { "id": "14", "name": "ListBox", "action": "ListBox", "childcount": "0" },
           { "id": "15", "name": "Maps", "action": "Maps", "childcount": "0" },
           { "id": "16", "name": "Menu", "action": "Menu", "childcount": "0" },
           { "id": "17", "name": "PivotGrid", "action": "PivotGrid", "childcount": "0" },
           { "id": "18", "name": "OlapChart", "action": "OlapChart", "childcount": "0" },
           { "id": "19", "name": "OlapClient", "action": "OlapClient", "childcount": "0" },
           { "id": "20", "name": "OlapGauge", "action": "OlapGauge", "childcount": "0" },
           { "id": "21", "name": "Rating", "action": "Rating", "childcount": "0" },
           { "id": "22", "name": "Ribbon", "action": "Ribbon", "childcount": "0", "isResponsive": "false" },
           { "id": "23", "name": "RichTextEditor", "action": "RichTextEditor", "childcount": "0" },
           { "id": "24", "name": "RangeNavigator", "action": "RangeNavigator", "childcount": "0" },
           { "id": "25", "name": "Rotator", "action": "Rotator", "childcount": "0" },
           { "id": "26", "name": "Schedule", "action": "Schedule", "childcount": "0" },
           { "id": "27", "name": "Slider", "action": "Slider", "childcount": "0" },
           { "id": "28", "name": "TagCloud", "action": "TagCloud", "childcount": "0" },
           { "id": "29", "name": "Textboxes", "action": "Textboxes", "childcount": "0" },
           { "id": "30", "name": "TimePicker", "action": "TimePicker", "childcount": "0" },
           { "id": "31", "name": "Toolbar", "action": "Toolbar", "childcount": "0" },
           { "id": "32", "name": "TreeGrid", "action": "TreeGrid", "childcount": "0" },
           { "id": "33", "name": "TreeMap", "action": "TreeMap", "childcount": "0" },
           { "id": "34", "name": "TreeView", "action": "TreeView", "childcount": "0" },
           { "id": "35", "name": "ReportViewer", "action": "ReportViewer", "childcount": "0" }
           ]
       },
        {
            "name": "KnockoutJS",
            "id": "KOSupport",
            "childcount": "1", "isResponsive": "true",
            "Group": "INTEGRATION",
            "action": "AutoComplete",
            "samples": [
              { "id": "1", "name": "AutoComplete", "action": "AutoComplete", "childcount": "0" },
			  { "id": "2", "name": "BulletGraph", "action": "BulletGraph", "childcount": "0" },
			  { "id": "4", "name": "Chart", "action": "Chart", "childcount": "0" },
			  { "id": "330", "name": "CircularGauge", "action": "CircularGauge", "childcount": "0" },
              { "id": "5", "name": "ColorPicker", "action": "ColorPicker", "isResponsive": "false", "childcount": "0" },
              { "id": "6", "name": "DatePicker", "action": "DatePicker", "childcount": "0" },
              { "id": "7", "name": "DateTimePicker", "action": "DateTimePicker", "childcount": "0" },
			  { "id": "8", "name": "Diagram", "action": "Diagram", "childcount": "0" },
			  { "id": "9", "name": "DigitalGauge", "action": "DigitalGauge", "childcount": "0" },
              { "id": "10", "name": "DropDownList", "action": "DropDownList", "childcount": "0" },
			  { "id": "11", "name": "Gantt", "action": "Gantt", "childcount": "0" },
			  { "id": "12", "name": "Grid", "action": "Grid", "childcount": "0" },
			  { "id": "13", "name": "LinearGauge", "action": "LinearGauge", "childcount": "0" },
			  { "id": "14", "name": "ListBox", "action": "ListBox", "childcount": "0" },
              { "id": "15", "name": "Menu", "action": "Menu", "childcount": "0" },
			  { "id": "16", "name": "PivotGrid", "action": "PivotGrid", "childcount": "0" },
			  { "id": "17", "name": "OlapChart", "action": "OlapChart", "childcount": "0" },
			  { "id": "18", "name": "OlapClient", "action": "OlapClient", "childcount": "0" },
              { "id": "19", "name": "OlapGauge", "action": "OlapGauge", "childcount": "0" },
              { "id": "20", "name": "RangeNavigator", "action": "RangeNavigator", "childcount": "0" },
			  { "id": "21", "name": "Rating", "action": "Rating", "childcount": "0" },
			  { "id": "22", "name": "Ribbon", "action": "Ribbon", "childcount": "0", "isResponsive": "false" },
              { "id": "23", "name": "RichTextEditor", "action": "RichTextEditor", "childcount": "0" },
              { "id": "24", "name": "Rotator", "action": "Rotator", "childcount": "0" },
              { "id": "25", "name": "Schedule", "action": "Schedule", "childcount": "0" },
              { "id": "26", "name": "Slider", "action": "Slider", "childcount": "0" },
              { "id": "27", "name": "TagCloud", "action": "TagCloud", "childcount": "0" },
              { "id": "28", "name": "Textboxes", "action": "Textboxes", "childcount": "0" },
              { "id": "29", "name": "TimePicker", "action": "TimePicker", "childcount": "0" },
              { "id": "30", "name": "Toolbar", "action": "Toolbar", "childcount": "0" },
              { "id": "31", "name": "TreeGrid", "action": "TreeGrid", "childcount": "0" },
              { "id": "32", "name": "TreeView", "action": "TreeView", "childcount": "0" },
			  { "id": "33", "name": "ReportViewer", "action": "ReportViewer", "childcount": "0" }
            ]
        }
];
