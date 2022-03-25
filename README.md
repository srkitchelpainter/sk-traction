# LearnSc93Proj #

This README documents the steps necessary to get this application up and running for training, development and testing purposes as well as Sitecore Developer Certification professional competency supplemental training material.

Sitecore Developer Training Sandbox 1.0. Sitecore Developer Certification professional competency supplemental training material and enrichment for the course of study. 

Sitecore Traction Project 2.0. ArticlesController.cs builds a module which imports a file into Sitecore representing content schema and creates data templates representing the schema.

# Installation Competencies: + Download and Install Sitecore.#
## Software Required ##

* Sitecore 9.3.0 rev. 003498 (Setup XP0 Developer Workstation rev. 1.1.1-r4)
* Packages for XP Single (On Prem). Sitecore 9.3.0 rev. 003498 (OnPrem)_single.scwdp.zip
* Sitecore Install Framework 2.1+
* Visual Studio 2019
* Powershell Tools for Visual Studio
* Install the Node.js Development Workload
* .NET Framework 4.7.2
* MS SQL Server 2016 SP2 or later
* URL Rewrite 2.1
* SOLR 7.2.1: https://lucene.apache.org/solr/guide/7_2/installing-solr.html
	* Java Runtime Environment
* GIT

### Prerequisites ###
  * Ensure you have IIS configured   
  * Ensure you have Sql Server **sa** user configured. 
  * Enable Contained Database Authentication by running the following SQL query:
    ```
    sp_configure 'contained database authentication', 1;
    GO
        RECONFIGURE;
    GO
  ```
    * Development Competency: 
        + Set up a Visual Studio solution and project for Sitecore development
        + Prepare the Sitecore Rocks Visual Studio plug-in and set up a connection to a Sitecore instance
            + Items Competency: Use Sitecore Rocks to create content

## Install the Sitecore instance ##
### 1. Create a new resources folder `C:\sc93_install`
Create a working folder which will contain scripts, configuration, and installation files.

### 2. Download Sitecore Install Assistant (SIA)
Installation Competency: + Install Sitecore with Sitecore Install Assistant.

'Graphical setup package for XP Single'
https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/93/Sitecore_Experience_Platform_93_Initial_Release.aspx

Extract the files into the resources folder. 

### 3. Copy license.xml to `C:\sc93_install`
Copy appropriate license to installation folder.

### 4. SIA Config Updates
Before you run and execute setup.exe file you can update some of the settings of SIA using setup.exe.config file and some of the settings which you can update are as follows:
    * SQL Server name: DESKTOP-TPSQ00C
    * SOLR URL: https://localhost:8984/solr
    * SOLR root: C:\Program Files\solr-7.2.1
    * Solr Service: solr-7.2.1

### 5. Run the SIA
Run setup.exe as an administrator. 
Follow the steps to complete installation. 
Installation Competency: + Use the default admin user name and password to log in to a Sitecore instance  

### 6. Test Access
Now that Sitecore is installed, verify that the site is up:

  1. Navigate to URL. http://sc93sc.dev.local
  2. Log into Sitecore and verify the password works

### 7. Post Installation
Follow the post installation steps as outlined in Sitecore Installation Guide.

### Installation Competencies 
+ Add or change configuration settings in the Sitecore.config file.

Examples:
*For Development testing environment, change <site> database to master. 
*Edit <settings>.

+ Create a Sitecore Project in Visual Studio.
+ Set up Sitecore and Visual Studio for Development.
+ Define the structure and files of a clean Sitecore instance.

Local Repository:
\source\repos\sitecore-traction-repo\LearnSc93Proj

Bitbucket Project:
https://bitbucket.org/simplea/sk-traction/src/master/
Local Folder: \source\repos\sitecore-traction-repo\sk-traction

+ Deploy a website.
http://sc93sc.dev.local/

Webroot:
C:\inetpub\wwwroot\sc93sc.dev.local

Publishing Profiles:
CustomProfile.pubxml

## Sitecore Developer Professional Competencies ##

### Installation ###

+ Identify the Sitecore applications and their users.
```
doc.sitecore.net
```

+ Describe how Sitecore's data infrastructure works on the MVC platform.
```
An incoming request is handled by Sitecore MVC in the following manner:

* Create a PageContext.
* Determine the requested item.
* Determine the relevant controller to invoke.
* Build the PageDefinition and assign it to the PageContext.
* Select the root rendering to use for generating the response (typically the layout assigned to the requested item).
* Wrap an IView around the root rendering and store it in PageContext.PageView.
* Pass the PageView to the ASP.NET MVC runtime for rendering the response to the client.
```

### Development Environment ###

+ Identify the core binary files of the Sitecore framework.
```
Sitecore.Kernel
Sitecore.MVC
Sitecore.MVC Analytics
```
+ Utilize and manage NuGet packages.
+ Utilize Team Development for Sitecore.

### Architecture ###

+ Define the Experience Content Management System (xManagement). 
```
Templates create data definition and infrastructure
Items manage a content tree structure
Layouts transform presentation that can be consumed (JSON, HTML, XML). 
```

+ Describe the features of a WCMS.
```
*Analytics monitor actions and engagements
*Insights seek to understand behaviors
*Decisions provide targeted content
*Automation creates individual conversations on and offline.
```

+ State the three foundation pillars of a WCMS. 
```
1. Authoring
2. Collaboration
3. Administration
```

+ Describe the Basic Development Architecture of Sitecore
```
ASP.NET Tools:
	*Visual Studio
	*MSBuild
	*IIS
	*MVC or Webforms
	*SQL Server or MongoDB layered architecture using API's.

https://doc.sitecore.com/developers/93/platform-administration-and-architecture/en/index-en.html
```

+ Explain how Sitecore can scale with use of server roles
```
Vertically: each role runs as a standalone application.

    Pre-Built Topologies:
        *XP Single - standalone instance. All core roles and XP services are combined.
        *XP Scaled - fully scaled instance. Every core role and XP service role is performed by a dedicated server.

Horizontally: dedicate multiple web applications to the same role within a topology using a load balancer. 

+ Define roles that interact with Sitecore
```
https://doc.sitecore.com/developers/93/platform-administration-and-architecture/en/architecture-and-roles.html
```

+ Identify the benefits of xConnect
```
- Records analytics data from any interaction.
- Integrates analytics data with other systems. 
- Secure by default
- Designed for scalability
- Supports multiple data storage technologies
- Integrated with Sitecore's personalisation technologies out-of-the-box
```

+ Organize the CMS for Content Editors.
+ Configure the CMS to be optimized for Content Editors.
+ Enable marketing features for end goals of the client.
+ Build a Sitecore solution based on client needs.
+ Receive feedback from Content editors and incorporate into solutions.

### Sitecore Documentation and Support ###

+ Locate Sitecore websites and documentation

- Sitecore Developer Network. https://dev.sitecore.net
    --contains downloads and documentation of supported Sitecore product and modules 8+.
- Sitecore Developer Portal. https://doc.sitecore.com/archive
    -- contains downloads and documentation of supported Sitecore product and modules prior to the 8.0 version.
- Sitecore Documentation. https://doc.sitecore.net/developers
    --contains all relevant documentation for the Sitecore Experience Platform and all associated products and modules for 8.0+.
- Sitecore Knowledge Base. https://kb.sitecore.net 
    --contains details about known issues, problems ad common questions related to Sitecore products with guidance to find the right solution.
- Master Sitecore Youtube channel. https://youtube.com/mastersitecore : 
    --contains freely available video tutorials for developers, business users and optimization experts.
- Helix Documentation Site (Habitat). https://helix.sitecore.net
    --collection of recommended practices and conventions for the solution architecture of Sitecore product implementations

Additional Resources:
    * app.slack.com/client/T09SHRBNU/C09SJ4FHC - Sitecore Slack Community
    * community.sitecore.net - Connect with thousands of Sitecore professionals around the globe on Sitecore Community. Here, you can discuss tips, tricks, - techniques, and solutions for everyday scenarios when you are working with the Sitecore Experience Platform. Have a question? Get help from hundreds of members, including Sitecore employees and Sitecore Certified developers and MVPs.
    * feeds.sitecore.net - Every day the community is producing new blog posts. To make all this content available to you, Sitecore Feeds aggregates Sitecore related blogs and indexes to keep you informed. Blogs from Sitecore employees and MVP's are directly available on: http://www.sitecore.net/learn/blogs/technical-blogs.aspx.
    * marketplace.sitecore.net - If you have created a cool module that you want to share with the community, the Sitecore Marketplace is where you can share your module or find modules created by other contributors. If you do not want to support your module yourself, you can ask Sitecore to review your module. Once accepted, the support desk can handle any questions for you. If a module gets widely used, it can even be embedded in the core product. Some great examples are: The Language Fallback module and the Experience Explorer.sitecore-community.github.io/docs - A community-driven collection of developer resources - including blogs, videos, references, and articles. Please note that although Sitecore employees contribute, this is not official Sitecore documentation.
    * http://sitecore-community.github.io/docs/
    * https://mvp.sitecore.com/

### Items ###

+ Identify when you need to use template inheritance

```
Thanks to inheritance, we can define abstract templates commonly to more data templates. 
Content items can contain a number of fields without always having to re-define them separately for every template.
```
+ State the importance of setting up icons on templates

```
Provides content managers assistance with identifying different types of Items.
```

+ Describe the purpose of the Standard Template

```
Standard template is a basic template, which Sitecore provides for its function. This template does not contain any fields but it inherits from a number of other templates thanks to which we are able to define the display name, layout details, publishing restrictions and workflow, etc. on the items. All of the fields inherited into standard template begin with__.
```

+ Create content items by using Insert Options

```
Example: /sitecore/content/Home/ArticleFeed/Articles/Article1
```

### Templates ###

+ Describe the data template building blocks.

```
Standard template, Template Inheritance, Template Sections, Template Fields
```

+ Describe the purpose of standard templates.

```
All items inherit, by default, from the Sitecore provided "Standard template". As a developer you may change security settings on particular fields
on the Standard template, thereby granting or denying roles or user Read or Write access to Standard template fields.
Note that most of the Standard template fields are Denied access to the Everyone user.  This means that only Administrator 
users may see these fields.  If you want to make currently protected fields visible to non-Administrator users, you must first set 
the Read access right to Inherit for the Everyone user.  Therefore, set the Read access right to Allow for roles and/or users that you want to be able to view the given field.  
Allow Write access for roles and users that should be able to modify the fields.
``

+ Identify components in a HTML template.

```

```

+ Identify when you need to use data template inheritance.

```
In Helix, think of template inheritance as interfaces on an item which exposes a certain set of data to the business logic. 
This makes it possible for a multiple modules and business logic to share items and content.
```

+ List what you should consider when you apply inheritance to data templates.

```
* avoid having more than two levels of inheritance, and

1. System Templates
If a template is going to be the base template for other templates, make sure it is only used for this purpose. 
Dont make your system templates inherit from each other. Dont make any items use these templates directly. 
Used for templates which form the fields of one section of another template.

2. Data Templates
These templates should be used for system settings items e.g. items for drop-down lists, or category items to assign to other 
content items. i.e. data templates are for content in your site which is not a page.

3. Page Templates
These are templates for page-level content items. These should rarely need to define their own fields. 
Instead make these templates inherit from one or more of your system templates. Dont be tempted to make page templates inherit 
from each other. It might seem like a good idea, but it reduces flexibility. Its better to have several page templates inherit 
from the exact same set of system templates than to inherit from each other as this keeps your inheritance hierarchy simple.

4. Parameters Templates
Templates used to specify rendering parameters for a Sublayout or XSL rendering. These will all inherit from the sitecore standard 
rendering parameters template, so there should be little need for these to inherit other templates.
```

+ State the importance of setting up icons on templates.

```
* To differentiate specific items visually. 
* To differentiate items based on specific templates visually
```

### Fields and Field Types ###

+ Some good references:

```
https://sitecore.namics.com/2018/12/20/cheatsheetfieldtypes/
https://nshackblog.wordpress.com/2017/10/07/full-list-of-sitecore-field-types-and-their-c-type-mapping/
```

### Presentation ###

+ Describe how component properties can be maintained by content authors.

```
https://doc.sitecore.com/users/100/sitecore-experience-platform/en/content-authoring.html
```

+ Describe how to limit content choices in the data source selection window.

```
Example: https://himynameistim.com/2017/08/29/sitecore-rendering-datasource-restrictions/
```

+ Describe placeholders and placeholder definition items.

```
Friday Sitecore Best Practice: How to Properly Use Placeholder Settings
https://www.youtube.com/watch?v=HDNdVLFTNLc
```

+ Name the different types of MVC renderings

```
View
Controller
Xsl
Url
Item
```

### Publishing ###

+ Describe the purpose of the Web, Master and Core databases
+ Demonstrate an understanding of Experience Manager storage roles. 

```
Master:
* Contains all versions of all content supporting CMS users. stores the master copy of all versions of all content items and media  unpublished or published  
across all languages and publishing targets. The Master database also contains settings used to shape the experience for visitors, for example, marketing goals and outcomes, 
form definitions, and commerce settings.

Web: 
* Contains published versions from Master supporting the Web site(s).

Core:
* Contains data controlling the Sitecore CMS user interfaces.stores infrastructure data needed to run Sitecore itself; hosts the standard Microsoft ASP.NET membership database 
for security users and roles in the default security domain.
```

### Versioning ###

+ Describe different content versioning options in Sitecore.

```
https://doc.sitecore.com/users/92/sitecore-experience-platform/en/versioning.html
https://doc.sitecore.net/sitecore_experience_platform/content_authoring/creating_and_editing_items/editing/edit_a_field_in_the_experience_editor
https://doc.sitecore.net/sitecore_experience_platform/developing/developing_with_sitecore/versioned_layouts/versioned_layouts
```

### Sitecore Terminology ###
*  https://doc.sitecore.com/SdnArchive/upload/sitecore6/sc61keywords/glossary-usletter.pdf
*  https://doc.sitecore.com/developers/82/sitecore-experience-platform/en/experience-platform-glossary.html


### Search and Indexing ###

+ List the available search providers that Sitecore offers.
+ Describe the differences between these search providers.

```
https://doc.sitecore.com/developers/91/platform-administration-and-architecture/en/using-solr,-lucene,-or-azure-search.html
```

+ Query the index.

```
web.config <log4net> set up.

*App_Data/logs/Crawling.log.{date}.txt 
*App_Data/logs/Search.log.{date}.txt
```

## Contribution guidelines ##

* Writing tests
* Code review
* Other guidelines

* [Learn Markdown](https://bitbucket.org/tutorials/markdowndemo)
