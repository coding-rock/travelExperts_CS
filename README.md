# Travel Experts Web and Desktop Application
- TechCareers Cohort-4 Summer 2020
- PROJ-207 
- Wrokshop 4 - Desktop App Prototype
## Team Name: CodeGenerators
- Team members: Patrick Chen, Tarak Alatrach, Stevyn Shen 

## Group Charter
###### Patrick Chen
  - Responsible for Products form: display product list, add new product, edit existing product, modify product-supplier relationship.
  - DevOp: setup GitHub for group collaboration

###### Tarek Alatrach
  - Responsible for all Packages form: Display and CRUD activities.
  - DevOp: setup GitHub for group collaboration

###### Stevyn Shen
  - Responsible for Suppliers form: Display and CRUD activities.
  
## Challenge and Solution  
1. SupplierID 
  - Challenge:The Suppliers Table setup in the provided DB script had SupplierId ranging from 68 to 13596. When adding new supplier to DB the SupplierId auto-generated value of "0". I wanted newly added SupplierId to have auto-generated value of "13597"
  - Action: Patrick suggested it has to do with the way the DB is setup. He modified the script so that the SupplierId had IsIdentity = Yes. This allowed added Suppliers in MSSM to be added with auto-generated SupplierId of "13597". However this gives error in application for Add funciton: identity_insert is set to off. I searched online and could not find a simple solution.
  - Solution: Tarek suggested to keep DB as provided since the auto-generation will likely skip over existing Ids.And it's not a big deal as long as functionality working. Made sense and used existing DB. Due to the way the provided DB was setup, I designed the app when adding a new supplier, the user enters an integer between 2-5 digits and the app checks for duplicated ID or supplier name before adding to the database.   

2. Team Collaboration on Visual Studio
  - There were quite a bit of wasted time with version control. Initially TA setup a web-form home page with 3 tabs, but we then found out Visual Studio makes tons of conflict with every minor adjustments and thus concluded that we couldn’t work on the same form at all. PC end up setting up a basic home page with three buttons to respective secondary pages and we each worked of a page (TA: Packages; PC: Products, SS: Suppliers). We were also working on the master file in the GitHub project and try to maximize the concept of “separation of concern” to minimize merging conflicts. I was the only one utilizing branching methods to avoid destroying other’s work or having work over-written. We thought it’d be nice for the instructor to provide a few options for working in groups on a team project.

## General Notes:
- Device tests: desktop, iphone 
- Browser tests: FireFox, Chrome
- [GitHub repo for Workshop-4](https://github.com/coding-rock/travelExperts_CS)

## Attributes: 
- [StackOverflow] (https://stackoverflow.com/)

## Contributors: 
- Jolanta Warpechowska-Gruca, Instructor
- Nerds from TechCareers, Class of Summer 2020
