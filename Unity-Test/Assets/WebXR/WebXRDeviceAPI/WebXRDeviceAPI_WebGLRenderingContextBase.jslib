
mergeInto(LibraryManager.library, {

    WebGLRenderingContextBase_MakeXRCompatible : function(id, callback) {
        var value = _WebIDL2Unity.references[id].makeXRCompatible();
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(){
            Module["dynCall_vi"](callback, promise);
        });

        return promise;
    }

});
