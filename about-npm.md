# [Starting a project with npm init]( https://docs.npmjs.com/cli/v10/commands/npm-init)

`npm init`

- Creating the package entry point: `index.js`
- install color as a dependency of npm-book: `npm install --save colors`

## The node_modules hierarchy


## Share hello-npm with the world, so to push it to GitHub and then publish the package to the npm registry

- create a local git repo
- commit everything
- push it to GitHub
- publishing to the npm registry—authentication, versioning, unpublishing, interfacing programmatically

```bash
$ git init
$ git add -A
$ git commit
$ git remote add origin git@rollandxyz/mpm-book.git
$ git push -u origin master
$ npm publish
```

```bash
$ npm install hello-npm
$ node -e "require('hello-npm')"
```
- display all the info from our package.json and then some `$ npm view hello-npm`
- display just the author and versions `$ npm view hello-npm author versions`
- open the project’s corresponding npmjs.org page or set the homepage in package.json `$ npm docs hello-npm`
- take us to the issue tracker at https://github.com/rollandxyz/hello-npm/issues. `$ npm issues hello-npm`

