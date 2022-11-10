
project="/Users/111244rfsf/Documents/Repositories/alecscripts"
allControllers="/Users/111244rfsf/Desktop/allControlers.txt"
allViews="/Users/111244rfsf/Desktop/allViews.txt"
controllers="$project/controllers"
views="$project/views"
cd $views

for view in "$views"/*
do 
    echo $view >> $allViews
done
