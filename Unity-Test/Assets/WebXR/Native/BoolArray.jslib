
mergeInto(LibraryManager.library, {
    WebIDL2UnityGetElementAtNative_BoolArray : function(id, index){
        return _WebIDL2Unity.references[id][index];
    },

    WebIDL2UnitySpliceNative_BoolArray_3 : function(id, start, deleteCount, item){
            _WebIDL2Unity.references[id].splice(start, deleteCount, item);
    },
    WebIDL2UnitySpliceNative_BoolArray_2 : function(id, start, deleteCount){
            _WebIDL2Unity.references[id].splice(start, deleteCount);
    },

    WebIDL2UnityIndexOfNative_BoolArray : function(id, item){
        return _WebIDL2Unity.references[id].indexOf(item);
    }
});
