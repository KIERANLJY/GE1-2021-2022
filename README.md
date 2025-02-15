# TU856/TU857/TU858/TU984 Games Engines 1 2021-2022



[![Video](http://img.youtube.com/vi/NMDupdv85FE/0.jpg)](http://www.youtube.com/watch?NMDupdv85FE)

## Resources
- [Class Facebook page](https://www.facebook.com/groups/438658600891194/)
- [Course Notes (out of date!)](https://drive.google.com/open?id=1CeMUWjCUa1Ere2fMmtLz5TCL4O136mxj)
- [Assignment](assignment.md)
- [Unity Tutorials](https://unity3d.com/learn/tutorials) 
- [GDC Vault](http://www.gdcvault.com/)
- [Game maths tutorials](http://www.wildbunny.co.uk/blog/vector-maths-a-primer-for-games-programmers/)

## Contact me
* Email: bryan.duggan@tudublin.ie
* [My website & other ways to contact me](http://bryanduggan.org)

## Week 1 - Introduction

## Lab

## Lecture
- [Slides](https://docs.google.com/presentation/d/1cyjd7Nhv0ea-R44LpR6UnuWLC1IJ9OOG/edit?usp=sharing&ouid=112533789876788921065&rtpof=true&sd=true)
- [Trigonometry Problem Set](https://1.cdn.edl.io/IDqRlI8C9dRkoqehbbdHBrcGT6m87gkCQuMKTkp0U7JvHvuG.pdf)

### Learning Outcomes
- Install Unity & git for Windows
- Get Unity running on the lab computers
- Set up the fork, clone it, merge the upstream, commit and push into your fork
- Create a little thing in Unity 

### Instructions
- Sign up for the [class Facebook page](https://www.facebook.com/groups/247042854008746)
- Create a Unity account if you don't already have one
- Install Unity on your laptop or get Unity going on the lab computers. This process is a little fiddley this year. 
    - When you launch Unity in the labs, you will get an error about there being no license installed. To get around this you have to log-in to Unity using your credentials and then activate a Unity personal license on the machine.
    - You will also need to go to Edit | Preferences and set the External Script Viewer to be VS Code
- Create an account on github if you don't already have one and be sure to set up a [personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token) as this is what you will have to use as a password now 
- Fork the repository for the course (click the fork button above)
- Clone the repository and cd into the folder  you cloned:

```bash
git clone http://github.com/YOUR_GIT_NAME/GE1-2021-2022
cd GE1-2021-2022
```

- Check to ensure the remotes are setup correctly. You should see both origin and upstream remotes. The origin remote should be the url to your repo and the upstream remote should be the url to my repo

```bash
git remote -v
```

- If you don't see the upstream remote, you can add it by typing:

```bash
git remote add upstream https://github.com/skooter500/GE1-2021-2022/
```

- Switch to a new branch

```bash
git checkout -b mylab1
```

- Now launch Unity and see if you can open the scene we made in class today and run it.
- If you are experienced at using Unity, here is a video of something you can try and make today (click the image for the video):

[![YouTube](http://img.youtube.com/vi/tL6ux8isdgY/0.jpg)](https://www.youtube.com/watch?v=tL6ux8isdgY)


You can open the scene Lab1 and put your solution here. 
- Create a dodecahedron prefab and set the material
- Attach the RotateMe script and add code to it
- Add code to the Generator script to instantiate the dodecahedrons from the prefab you made

I suggest you try and make a single circle of dodecahedrons first and then use a nested loop to make all the circles. You can use the dodecahedron model in the assets folder and you can use ColorMaterial on the dodecahedrons. You will be using the following Unity API calls in your solution:

```C#
Mathf.Sin(angle)
Mathf.Cos(angle)
GameObject.Instantiate()
transform.Rotate()
```

You will also need to know about the [Unit circle](https://www.khanacademy.org/math/algebra2/x2ec2f6f830c9fb89:trig/x2ec2f6f830c9fb89:unit-circle/v/unit-circle-definition-of-trig-functions-1) and also how to [calculate the circumference of a circle](https://www.wikihow.com/Calculate-the-Circumference-of-a-Circle)

- Commit your changes and push them to your own mylab1 branch. You will have to set the upstream remote the first commit you make onto the branch

```bash
git add .
git commit -m "message"
git push
```

Don't worry if you cant figure it out! It's only the first week and I will do through the solution in the class next week :-)

