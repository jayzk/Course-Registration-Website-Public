# CoursEZ: Course Registration System
Final project for CPSC 481 Human-Computer Interactions. Was developed by me and 4 other members

## Description
The CoursEZ registration system offers the user with two distinct modes of enrollment: "Guided mode" and "Advanced mode". "Advanced mode" provides access to all functionalities of the system and a wealth of information on one screen. However, for new users, this can prove to be overwhelming and complex. To alleviate this, the system provides "Guided mode" which breaks down the enrollment process into simple, step-by-step instructions.

## Avaliable courses
- **CPSC 481: Human-Computer Interaction I**
  - Professor: Blanche Harvey
- **CPSC 449: Programming Paradigms**
  - Professor: Kelly Oliver
- **CPSC 399: Reverse Engineering**
  - Professor: Mariam Mitchell
- **GEOG 280: Thinking Spatially in a Digital World**
  - Professor: Riya Peterson
- **ASTR 209: Introduction to Astronomy II - The Cosmos**
  - Professor: Andrew Hess
- **ASPH 305: Introduction to Astrophysics**
  - Professor: Blake Landry
- **SENG 300: Introduction to Software Engineering**
  - Professor: Celia Hudson

## Implemented Functions and Features
- Can select to go through guided or advanced mode
- Can swap between guided and advanced mode after selection
- Can swap between terms
- Can view enrollment dates
- Can press the CourseEZ logo to return to the home page
- Can sign up for email notifications
- Can swap between different steps in guided mode using the step display at the top, or pressing the green buttons in each step
- Can search for courses by course number, course title or professor
- Can view course descriptions and other details of selected courses by opening the dropdown on the course title
- Can add and remove courses from selected list
- Can remove all selected courses that are not waitlisted or enrolled
- Can enroll, drop and waitlist for courses
- Can view different potential schedules
- Can select different semesters
- Can view and check degree requirements
- Can bookmark courses and save course schedules
- Can view an image of your class schedule
- Can hide courses to prevent them from showing up on schedule view while keeping them selected
- Can view a list of all possible times for a course by opening the potential lecture/tutorial times dropdown for a course
- Can select which course times show up on the schedule using the check boxes in the lecture/tutorial times dropdown

### Partially implemented functions and features
The functionality of these functions and feature have only been partially implemented for the purpose of this project and demo. As such, what can be inputted and what works will be specified down below
- Saving and loading schedules
  - Can save a schedule name by clicking on "Save Schedule" and it will be added to the dropdown list of "load schedule(s)"
  - However, actually loading a schedule will not work. Instead a popup will appear saying that this is still under development
- Applying advanced search filters 
  - In the current system, only the "Subject" and "Course Number" have implemented functionality
- Clicking on a course link to add to the list of selected courses (in course descriptions and required and recommeneded courses)
  - Course links in course descriptions can be added
  - However, some courses within "required and recommended courses" have not been implemented. Instead a popup will appear saying that it is still under development
- Clicking on a course requirement link to apply a custom advanced search filter (in required and recommeneded courses)
  - Some links like "Non-major Field Option" can be applied to the advanced search filters
  - However, there are also some links that have not been implemented yet. Instead a popup will appear saying that it is still under development
- Blocking certain times by clicking on the schedule 
  - This feature will only work on Thursday from 8:00am - 11:00am

### Cases and scenarios implemented
- If any time conflicts arise the schedule will disappear and display an alert error (Through two course times overlapping or a blocked time overlapping with courses)
- Protection to prevent dropping courses accidently by requiring queueing for dropping with the trash can icon, pressing "get this schdule" and then proceeding past a warning before dropping
- To let the user know that they can block times in the course viewer, the button "tip" is provided to let the user know of this feature
- An error occurs if user tries to enroll in a course they have already completed
- An error occurs if user attempts to enroll with no courses selected or if there are any anti-requisites present

## Running the system
1. Open the program in Visual Studio
   - Ensure ASP.net and web development installed
   - Ensure .NET desktop development is installed
   - Note: the system was implemented in Blazor Webassembly
3. Run using CPSC481_FinalProject.sln
3. Click on "Start without debugging" (Ctrl + F5)
4. If needed, zoom out to 80% on the webpage
   - On some monitors and screens, it may be necessary to zoom out in order to see all the components of the system due to the resolution being hardcoded
   - Unfortunately, no fix has been found for this issue at the moment

## Guided mode walkthrough and example

### Step 1: Select Courses
1. In the starting page, click on "Guided" to get to the first step of guided mode
2. Once in step 1 you will notice that "CPSC 481" is already in the list of selected courses as we are already enrolled in the course
   - For the sake of this walkthrough, we are assuming that the user is already enrolled in a course (CPSC 481) for the Winter 2023 
3. In the box of "CPSC 481", click the arrow on the right. The box will then expand and reveal the course details for "CPSC 481"
4. Once you are done looking at the details for "CPSC 481", click on the arrow again and the box will hide the course details again
5. In the left sidebar, under the section "Unsatisfied", click on "CPSC 449" to add the course to the list of selected courses
6. In the search bar type in "CPSC" and a dropdown of three courses should appear. Click on "CPSC 399" to add the course to the list of selected courses
7. Now expand the advanced search sidebar by clicking on "Advanced Search"
8. In the advanced search sidebar, click the box under "Subject" to reveal a dropdown of all avaliable subjects. Click on the subject "ASPH-Astrophysics"
9. Now scroll down in the advanced search sidebar and press "Save Changes". A text saying "Advanced search criteria applied" should appear under the search bar
10. In the search bar type in "CPSC" again and this time no courses should appear in the dropdown
11. Now type in "ASPH" in the search bar and a course should appear in the dropdown. Add that course to the list of selected courses
12. Now go back to the advanced search sidebar and click "Reset" to clear the applied filters
13. Now find the green button "Select Schedule" and press it to proceed to step 2
    - Alternatively you can also click "2" (a grey, round button) at the top to also get to step 2

### Step 2: Select Schedule
1. Once in step 2, you will notice that an error will appear on the right saying "CPSC 481 and CPSC 399 timings conflict. Please select another time."
2. To resolve this time conflict, press the eye icon in "CPSC 399". This will hide the course and now a schedule will be avaliable for you to see (without CPSC 399 of course)
3. To remove "CPSC 399" from the list of selected courses, click on the red x on the top-left corner of "CPSC 399"
4. You can expand the "Lecture/Tutorial Times" for "CPSC 449" and you will notice that there are two different potential times for "CPSC 449"
5. You can check and uncheck the boxes to see the different tutorial times of "CPSC 449"
6. Now click "Select All" to check both boxes again 
7. On top of the schedule, you will notice that we are "Viewing Schedule 1 out of 2". You can click on the right and left buttons beside it to view the different potential schedules
8. Once you are done viewing the different schedules, go back to "Viewing Schedule 1 out of 2" (press the left button). 
9. To block off certain times in the schedule, go to the Thursday column (labelled "Thu") and under it click on these time ranges:
   - 8:00am to 9:00am
   - 9:00am to 10:00am
   - 10:00am to 11:00am
   - 11:00am to 12:00pm
   - Note: for the purpose of this walkthrough, under Thursday, these are the only times that can be blocked off by the user
10. You will now notice that after clicking on those time ranges, "CPSC 449 Tut 01" will be removed from the schedule and "CPSC 449 Tut 02" will appear in a different timeslot
11. Moving the slider underneath the schedule will show different weeks of the schedule. Here, you will notice that the "ASPH 305" tutorials occur bi-weekly.
12. Now click the green button "Get this schedule" to proceed to step 3
    - Alternatively you can also click "3" (a grey, round button) at the top to also get to step 3
 
### Step 3: Get Schedule
1. Now in step 3, you will notice that there are issues with "ASPH 305". Unfortunately the seats are full for that course
2. If you uncheck the checkbox for "ASPH 305", the issue will now say that you will not be enrolled for "ASPH 305" as it is full. You will also not be waitlisted
3. Now check the checkbox for "ASPH 305" again
4. Press the green button "Confirm" which will enroll or waitlist you into the selected courses
5. A popup will then appear with the title "Schedule Enrollment was Successful", displaying all of the courses you are currently enrolled or waitlisted in
   - The popup will also let you know if you successfully drop a course
6. Close the popup
7. Now you will notice that the status of the courses has been updated accordingly
8. To go back to the starting page you can click the CoursEZ logo on the top-left corner

## Citations
- [Material Symbols and Icons - Google Fonts](https://fonts.google.com/icons?icon.query=bookmark&selected=Material+Symbols+Outlined:bookmark:FILL@1;wght@400;GRAD@0;opsz@48)
- [Bootstrap 5](https://getbootstrap.com/docs/5.1/getting-started/introduction/)
- [NuGet package: Blazored.Toast](https://github.com/Blazored/Toast)
- [NuGet package: Blazored.Typeahead](https://github.com/Blazored/Typeahead)
