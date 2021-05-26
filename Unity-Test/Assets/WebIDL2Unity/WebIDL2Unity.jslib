mergeInto(LibraryManager.library, {
    WebIDL2UnityDeleteReference: function (id) {
        _WebIDL2Unity.deleteReference(id);
    },

    WebIDL2UnityGetNewDictionnary: function () {
        return _WebIDL2Unity.addReference({});
    },

    WebIDL2UnityGetNewArray: function () {
        return _WebIDL2Unity.addReference([]);
    },

    WebIDL2UnityGetElementAtReference : function(id, index){
        return _WebIDL2Unity.addReference(_WebIDL2Unity.references[id][index]);
    },

    WebIDL2UnitySpliceReference_3 : function(id, start, deleteCount, item){
        _WebIDL2Unity.references[id].splice(start, deleteCount, _WebIDL2Unity.references[item]);
    },
    WebIDL2UnitySpliceReference_2 : function(id, start, deleteCount){
        _WebIDL2Unity.references[id].splice(start, deleteCount);
    },

    WebIDL2UnityIndexOfReference : function(id, item){
        return _WebIDL2Unity.references[id].indexOf(_WebIDL2Unity.references[item]);
    },

    WebIDL2UnityGetElementAtEnum : function(id,name, index){
        return _WebIDL2UnityEnums[Pointer_stringify(name)][_WebIDL2Unity.references[id][index]];
    },

    WebIDL2UnitySpliceEnum_3 : function(id,name, start, deleteCount, item){
         _WebIDL2Unity.references[id].splice(start, deleteCount, _WebIDL2UnityEnums[Pointer_stringify(name)][item]);
    },
    WebIDL2UnitySpliceEnum_2 : function(id,start, deleteCount){
        _WebIDL2Unity.references[id].splice(start, deleteCount);
    },

    WebIDL2UnityIndexOfEnum : function(id,name, item){
        return  _WebIDL2Unity.references[id].indexOf(_WebIDL2UnityEnums[Pointer_stringify(name)][item]);
    },

    WebIDL2Unity_reference_get : function(parentID, fieldName){
        var value = _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)];
        return value == null ? 0 : _WebIDL2Unity.addReference(value);
     },

     WebIDL2Unity_reference_set : function(parentID, fieldName, value){
         _WebIDL2Unity.references[parentID][Pointer_stringify(fieldName)] = (value == 0 ? null : _WebIDL2Unity.references[value]);
     },

     GetNavigatorID : function(){
        return _WebIDL2Unity.addReference(navigator);
     },

     WebIDL2UnityStringToPtr : function(value){
        var len = lengthBytesUTF8(value) + 1;
        var ptr = _malloc(len);
        stringToUTF8(fizzBuzz, ptr, len);
        return ptr;
     }
});

