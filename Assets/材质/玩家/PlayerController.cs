using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask layerMask; // 指定射线检测的层
    private Vector3 currentLookTarget = Vector3.zero; // 当前朝向的目标位置

    void FixedUpdate()
    {
        // 从相机到鼠标位置发射一条射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // 在场景视图中绘制射线，方便调试
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
        // 射线碰撞信息
        RaycastHit hit;
        // 如果射线与指定层的物体相交
        if (Physics.Raycast(ray, out hit, 1000, layerMask, QueryTriggerInteraction.Ignore))
        {
            // 如果相交点不等于当前朝向的目标位置
            if (hit.point != currentLookTarget)
            {
                // 更新当前朝向的目标位置为相交点
                currentLookTarget = hit.point;
            }
            // 定义一个目标位置，忽略y轴坐标，使人物不会倾斜
            Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            // 根据目标位置和人物位置计算出旋转角度
            Quaternion rotation = Quaternion.LookRotation(targetPosition - transform.position);
            // 平滑地旋转人物，使其朝向目标位置
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10.0f);
        }
    }
}