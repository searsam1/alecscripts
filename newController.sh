
# Create new controller and index view 
# By Alec Sears

cd "/Users/111244rfsf/Documents/Repositories/alecscripts"

# collect controller input 
read -p "Controller Name? " controller
# run dotnet-aspnet-codegenerator to create 
# a new controller 
script1='dotnet-aspnet-codegenerator -p MvcAlecScripts.csproj controller -name '$controller'Controller -outDir Controllers -namespace MvcAlecScripts.Controllers'
echo "Running Script: "$script1


$script1
newView=$controller
echo 'Creating View: '$newView

# Crete new View/controller folder 
mkdir "Views/"$controller
echo 'Creating Index: '"Views/"$controller"/index.cshtml"

# Create new View/controller/index.cshtml file 
touch "Views/"$controller"/index.cshtml"

# Update Sidebar
python3 "/Users/111244rfsf/Documents/Repositories/alecscripts/__update_sidebar.py"

# open new controller and view 
code "Views/"$controller"/index.cshtml" && code "Controllers/"$controller"Controller.cs"