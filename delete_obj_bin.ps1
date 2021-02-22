$path= (Get-Item -Path ".\" -Verbose).FullName

$fLst = get-childitem $path -recurse
$fso = New-Object -ComObject scripting.filesystemobject

foreach ($f in $fLst) {
    if($f.Name -eq "bin" -Or $f.Name -eq "obj" ){
        #$f.fullname
        $fso.DeleteFolder($f.fullname)
        #remove-item $f.fullname -recurse -force
    }
}