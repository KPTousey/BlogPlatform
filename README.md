# Blog Platform
## Objective
- Students will employ good software design and testing principles in order to create a full-stack, server-side-rendered, web application.
- Students will build the front-end portion using HTML and CSS. (No frameworks, No JavaScript... at all)
- Students will build the back-end portion using ASP.Net Core, Entity Framework and a SQL database.

## The Scenario
We've been hired by NobodyCares Inc. to build a Proof of Concept (PoC) application for a company looking to make the next new hot blogging platform! This being a PoC app, we don't (yet) have to worry about all of the security and user management concerns that we would have in a fully functional application. All our client wants from us are the beginnings of the actual User eXperience (UX). Our client also wants an in depth and COMPLETE look at our applications User Interface (UI), so let's make it look good.


## Contents
We can't very well have a blog without some content. Each Content instance should include:
- Title
- Body
- Author
- PublishDate (Look into the DateTime class for this)
- Category (Content should have only one)

Seed your database with at least 2-3 examples of Content for each Category.

## Categories
Each Category should have:
- Name
- Content (Each Category can have multiple Content instances)
