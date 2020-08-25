//var sut = sut || {};

//sut.startRandomGenerator = function (dotNetObject) {
//    setInterval(function () {
//        let text = Math.random() * 1000;
//        console.log("JS: Generated " + text);
//        dotNetObject.invokeMethodAsync('AddText', text.toString());
//    }, 1000);
//};


var sut = sut || {};
sut.startRandomGenerator = function (dotNetObject) {
    return setInterval(function () {
        let text = Math.random() * 1000;
        console.log("JS: Generated " + text);
        dotNetObject.invokeMethodAsync('AddText', text.toString());
    }, 1000);
};

sut.stopRandomGenerator = function (handle) {
    clearInterval(handle);
};
