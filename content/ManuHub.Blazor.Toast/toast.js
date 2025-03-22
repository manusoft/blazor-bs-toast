export function showToast(title, message, timestamp, bgClass = "text-bg-light", positionClass = "bottom-0 end-0") {
    try {
        const conatnerElement = document.getElementById('toastContainer');
        if (conatnerElement) {
            conatnerElement.classList
                .remove("top-0", "bottom-0", "start-0", "end-0", "start-50", "top-50", "translate-middle-x", "translate-middle-y", "translate-middle");

            // Add position classes separately
            positionClass.split(" ").forEach(cls => conatnerElement.classList.add(cls));
        }

        const toastElement = document.getElementById('liveToast');
        if (toastElement) {
            document.getElementById('toastTitle').innerText = title;
            document.getElementById('toastTimestamp').innerText = timestamp;
            document.getElementById('toastMessage').innerText = message;

            // Remove existing background classes
            toastElement.classList.remove("text-bg-light", "text-bg-success", "text-bg-danger", "text-bg-warning", "text-bg-info");
            
            // Add background class
            toastElement.classList.add(bgClass);           

            let toast = new bootstrap.Toast(toastElement);
            toast.show();
        }
    } catch (error) {
        console.error("Error displaying toast:", error);
    }
};