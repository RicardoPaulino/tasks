const { createApp, ref } = Vue

createApp({
    setup() {
        const message = ref('This is Vue Project')
        return {
            message
        }
    }
}).mount('#app')