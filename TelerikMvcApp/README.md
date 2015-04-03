# Telerik MVC App for Cardno


Work yet to do (Isn't there always :)

1.  Add the database with WebAPI Services
2.  DataContext/Mappings for Entity Framework
3.  Repositories/Factories
4.  Container, I like to use Unity for Dependency injection
5.  Validations need to be completed and tested, Validation for String length is not working
    as it needs to be.

Packages added thru Nuget

1.  jquery.UI.Combind
2.  JQuery.Form - Did not use
3.  jQuery.Unobtrusive
4.  Updated Jquery

Once a Candidate is Added, they are added to the grid and
should then be saved into the db.

Search Functionality
Currently, Search functionality is still not working yet. Ran out of time.

Managing Packages

Currently a few scripts are obsolute.  These need to be cleaned up and 
bundled correctly in the Bundle class instead of put into the Layout file.

Layout/Banner needs more work.

Notifications

I have used kendo notifications which are quite nice but currently I am using Toast for 
notifications, very nice too. 

The Candidate will be added to the grid but the back end still refreshes the grid
to the hard coded values.  That will change one I add in a DB and the read
function for the grid will read directly from the db service.


I started at about 11 am and installed the Kendo Telerik controls.
Happy Programming!
