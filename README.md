# FoxmindEd_Task8
The project was created by Oleksandr Havlytskyi for educational purposes at the FoxmindEd course.
____
**Technology or principles have been mastered( or repeated):** WPF, MVVM, MSSQL Serve, Entity Framework Core, Generic Repository, Unit Of Work, app file architecture.
____
**The purpose of the project:** Learn to create a desktop application to store data in a database.

**Task description:**
Create a WPF (WinForms) application for working with data from task 6 (and extend it for a new entity - Teacher).

1. On the default page Ц show a list of courses. When the course is selected - show a list of groups for the selected course. 
When the group is selected - show a list of students for the selected group. (You can replace course and group lists with a treeview)

2. A separate page for create/delete groups and edit group (change group name, select/update teacher of group). 

		a) ItТs also necessary to add functionality (buttons) for export/import a list of students of a group to a csv file (separator is У,Ф). 
		Before importing students into a group, you have to clear the group where you are uploading new students.
		A group can not be deleted if there is at least one student in this group.

		b) There should be an ability to create a docx/pdf file with a list of the group, with the following content:
		The document title:
		- the course name
		- the group name
		The document itself:
		- a numbered list of students (full name)



3. A separate page for editing students (add, update and delete), Change student data (name, surname)
4. Add a new entity Teacher (name, surname). Add the page for editing (add, update and delete). It is also necessary that each group of students could have a tutor. 


