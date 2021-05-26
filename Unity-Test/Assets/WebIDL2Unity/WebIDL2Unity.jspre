
_WebIDL2Unity = {
    next: 1,
    references: { 0: null },
    addReference: function (obj) {
        if (obj==null) {
            return 0;
        }
        else {
            var id = this.next;
            this.references[id] = obj;
            this.next++;
            return id;
        }
    },
    deleteReference: function (id) {
        console.group("Delete object");
        console.log(id);
        console.log(this.references[id]);
        console.groupEnd();
        if (id !== 0) delete this.references[id];
    }
}

if(typeof _WebIDL2UnityEnums == "undefined") _WebIDL2UnityEnums = {}