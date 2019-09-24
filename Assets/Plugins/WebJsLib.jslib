mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },


  HelloString: function (str) {
    android.ShowString(Pointer_stringify(str));
  },

});