<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0 user-scalable=no" />
<meta name="description" content="Essential Studio for JavaScript" />
<meta name="author" content="Syncfusion" />
<link href="themes/bootstrap.min.css" rel="stylesheet" />
<link href="themes/ejthemes/ej.widgets.core.min.css" rel="stylesheet" />
<link href="themes/ejthemes/default-theme/ej.web.all.min.css" rel="stylesheet" />
<!--Dependency files references-->
<!--[if lt IE 9]>
<script src="Scripts/jquery-1.11.3.min.js" type="text/javascript" ></script>
<![endif]-->
<!--[if IE 9]><!-->
<script src="Scripts/jquery-3.4.1.min.js" type="text/javascript"> </script>
<!--<![endif]-->
<script src="Scripts/jsrender.min.js" type="text/javascript"></script>
<script src="Scripts/ej.web.all.min.js" type="text/javascript"></script>

</head>
<body>
<?php
require_once 'EJ/AutoLoad.php';
?>
<div class="cols-sample-area">
    <?php                
                $fileexplorer=new EJ\FileExplorer('default');
                echo $fileexplorer
                    ->path('FileExplorerPHP/FileBrowser/')
                    ->ajaxAction('EJ/Services/FileExplorer')
                    ->ajaxDataType('jsonp')
                    ->enableThumbnailCompress(true)
                    ->width('100%')
                    ->isResponsive(true)
                    ->render();
                ?>
 
</div>

<style>
    .cols-sample-area
    {
        margin: 0 auto;
        float: none;
	    padding: 50px;
    }
</style>
</body>
</html>