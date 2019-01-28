"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    sass = require('gulp-sass'),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    sourcemaps = require('gulp-sourcemaps');

var www = './wwwroot/';
var npm = './node_modules/';

gulp.task("clean:ts", function (cb) {
    rimraf(www + "ts/", cb);
});

gulp.task("clean:js", function (cb) {
    rimraf(www + "js/", cb);
});

gulp.task("clean:scss", function (cb) {
    rimraf(www + "scss/", cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(www + "scss/", cb);
});

gulp.task("clean", ["clean:ts", "clean:js", "clean:scss", "clean:css"]);


gulp.task("compile:scss", function () {
    return gulp.src('./Styles/*.scss')
        .pipe(sourcemaps.init())
        .pipe(sass().on('error', sass.logError))
        .pipe(sourcemaps.write())
        .pipe(gulp.dest(www + 'scss/'));
});

gulp.task('watch:scss', function () {
    gulp.watch("./Styles/**/*.scss", ['compile:scss']);
});


gulp.task("min:js", function () {
    return gulp.src([www + 'ts/*.js'])
        .pipe(concat(www + 'js/site.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([www + 'scss/*.css'])
        .pipe(concat(www + 'css/site.min.css'))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);