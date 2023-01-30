#!/bin/bash
str=""
for folder in Views/*; do 
    f=$(basename -- "$folder")
    str+="\n## $f\n"
    for filename in $folder/*.cshtml; do
        f=$(basename -- "$filename")
        extension="${f##*.}"
        name="${f%.*}"
        str+="- ["$name"]($filename)\n"
    done
done

echo -e $str | pbcopy